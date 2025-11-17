using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms.VisualStyles;
using BlinkReader;
using BlinkReader.Forms;
using Gen6RNG;
using PokemonPRNG.TinyMT;


namespace Gen6BlinkReader.Main
{
    public partial class SeedSearchControl : UserControl
    {
        private BindingList<RNGResult> RNGResults = new();
        private CancellationTokenSource seedSearchCts = new();
        private CancellationTokenSource resultViewCts = new();
        private Settings settings;
        private ConcurrentQueue<RNGResult> resultQueue = new();
        private ManualResetEvent queueEvent = new(false);
        public event EventHandler? ObserveStarted;
        public event EventHandler? ObserveStopRequested;
        public event EventHandler? ObserveCompleted;

        public SeedSearchControl()
        {
            InitializeComponent();
            this.InitializeControlEvents();
        }

        public void Init(CaptureWindowForm captureWindowForm, Settings settings)
        {
            this.blinkObserveControl.Init(captureWindowForm, settings);
            this.settings = settings;
        }

        private void InitializeControlEvents()
        {
            this.resultGridView.DataSource = RNGResults;
            this.searchButton.Click += (sender, e) => this.SeedSearchAsync();
            this.cancelButton.Click += (sender, e) => this.SearchCancelRequest();
            this.Disposed += (sender, e) => this.ResultViewDispose();

            this.bruteForceRadioButton.CheckedChanged += (sender, e)
                => this.baseSeedTextBox.Enabled = this.baseSeedRadioButton.Checked;

            this.blinkObserveControl.StartButtonClick += (sender, e) =>
            {
                this.ObserveStarted?.Invoke(this, e);
                this.searchButton.Enabled = false;
            };

            this.blinkObserveControl.StopButtonClick += (sender, e) =>
            {
                this.ObserveStopRequested?.Invoke(this, e);
                this.searchButton.Enabled = true;
            };

            this.blinkObserveControl.ObserveCompleted += (sender, e) =>
            {
                this.ObserveCompleted?.Invoke(this, e);
                this.searchButton.Enabled = true;
            };

            this.UpdateResultView();
        }

        private void UpdateResultView()
        {
            Task.Run(() =>
            {
                while (!resultViewCts.Token.IsCancellationRequested)
                {
                    this.queueEvent.WaitOne();
                    if (this.resultQueue.TryDequeue(out var result))
                        this.Invoke(() => this.RNGResults.Add(result));
                    Thread.Sleep(100);
                }
            }, this.resultViewCts.Token);
        }

        private void ResultViewDispose()
        {
            this.resultViewCts.Cancel();
            this.resultViewCts.Dispose();
        }

        private async void SeedSearchAsync()
        {
            var intervals = this.blinkObserveControl.GetIntervals();
            if (Debugger.IsAttached)
                intervals = [399, 410, 313];

            if (!intervals.Any())
                return;

            var lower = (uint)this.lowerUpDown.Value;
            var upper = (uint)this.upperUpDown.Value;
            ulong max = uint.MaxValue + 1UL;
            var proc = this.settings.Threads;
            var range = max / (ulong)proc;
            var options = new ParallelOptions { CancellationToken = seedSearchCts.Token, MaxDegreeOfParallelism = proc };
            ulong totalProgress = 0;
            var prevProgress = 0.0;

            Func<ulong, uint> seedMapper;
            if (this.baseSeedRadioButton.Checked)
            {
                if (!uint.TryParse(this.baseSeedTextBox.Text, NumberStyles.HexNumber, null, out uint baseSeed))
                {
                    MessageBox.Show("基準seedが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                seedMapper = (ulong offset) => (uint)((baseSeed + offset) % max);
            }
            else
                seedMapper = (ulong s) => (uint)s;

            this.queueEvent.Set();
            this.RNGResults.Clear();
            this.searchButton.Enabled = false;
            this.searchButton.Text = "0.0%";

            await Task.Run(() =>
            {
                try
                {
                    Parallel.For(0, proc, options, i =>
                    {
                        var start = (ulong)i * range;
                        var end = (i == proc - 1) ? max : start + range;

                        for (ulong j = start; j < end; j++)
                        {
                            options.CancellationToken.ThrowIfCancellationRequested();
                            uint initSeed = seedMapper(j);
                            if (IndexFinder.TryGetIndex(initSeed, lower, upper, intervals, out uint result))
                            {
                                // var seed = initSeed.TinyMT();
                                // seed.Advance(result);
                                this.resultQueue.Enqueue(new RNGResult(initSeed, result, result + (uint)intervals.Length));
                            }

                            var progress = Interlocked.Increment(ref totalProgress);
                            double _progress = (double)progress / max * 100.0;
                            if (_progress - prevProgress >= 0.1)
                            {
                                prevProgress = _progress;
                                var text = _progress.ToString("0.0") + "%";
                                this.Invoke(() => this.searchButton.Text = text);
                            }
                        }
                    });
                }
                catch (OperationCanceledException) { }
            }, this.seedSearchCts.Token);
            this.CancelRequestRecieved();
        }

        private void SearchCancelRequest()
        {
            this.seedSearchCts.Cancel();
            this.seedSearchCts.Dispose();
            this.seedSearchCts = new();
        }

        private void CancelRequestRecieved()
        {
            this.queueEvent.Reset();
            this.resultQueue.Clear();
            this.searchButton.Text = "検索";
            this.searchButton.Enabled = true;
        }

        public void SetControlEnabled(bool enabled)
        {
            this.searchButton.Enabled = enabled;
            this.cancelButton.Enabled = enabled;
            this.blinkObserveControl.SetStartButtonEnabled(enabled);
        }
    }

    public class RNGResult
    {
        public RNGResult(uint seed, uint advance, uint totalAdvances)
        {
            this.InitSeed = $"{seed:X8}";
            this.Advance = advance;
            this.TotalAdvances = totalAdvances;
        }

        [DisplayName("初期seed")]
        public string InitSeed { get; private set; }

        [DisplayName("消費数")]
        public uint Advance { get; private set; }

        [DisplayName("合計消費数")]
        public uint TotalAdvances { get; set; }
    }
}
