using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Media;
using BlinkReader.Forms;
using Gen6RNG;
using PokemonPRNG.TinyMT;
using Gen6BlinkReader;

namespace Gen6BlinkReader.Main
{
    public partial class BlinkSearchControl : UserControl
    {
        private CancellationTokenSource tokenSource = new();
        private bool isWorking = false;
        private double fps = 59.8261;
        private int offset = 0;
        private SoundPlayer BlinkSound;
        public event EventHandler? ObserveStarted;
        public event EventHandler? ObserveStopRequested;
        public event EventHandler? ObserveCompleted;
        public event EventHandler? TimerStarted;
        public event EventHandler? TimerStopped;

        public BlinkSearchControl()
        {
            InitializeComponent();
            this.InitializeControlEvents();
            var memoryStream = new MemoryStream(Properties.Resources.beep);
            this.BlinkSound = new SoundPlayer(memoryStream);
        }

        public void Init(CaptureWindowForm captureWindowForm, Settings settings)
        {
            this.blinkObserveControl.Init(captureWindowForm, settings);
        }

        private void InitializeControlEvents()
        {
            // 初期seedが入力されていない時は瞬きを観測できないようにする
            this.blinkObserveControl.SetStartButtonEnabled(false);
            this.initSeedTextBox.TextChanged += (sender, e) =>
                this.blinkObserveControl.SetStartButtonEnabled(this.initSeedTextBox.Text.Length != 0);

            this.blinkObserveControl.StartButtonClick += (sender, e) =>
            {
                this.ObserveStarted?.Invoke(this, e);
                this.SetInputControlEnabled(false);
            };

            this.blinkObserveControl.StopButtonClick += (sender, e) =>
            {
                this.ObserveStopRequested?.Invoke(this, e);
                this.SetInputControlEnabled(true);
            };

            this.blinkObserveControl.ObserveCompleted += async (sender, e) =>
            {
                this.ObserveCompleted?.Invoke(this, e);
                this.blinkObserveControl.SetStartButtonEnabled(false);
                await this.BlinkSearch();
                this.SetInputControlEnabled(true);
                this.blinkObserveControl.SetStartButtonEnabled(true);
            };

            this.timerStopButton.Click += (sender, e) =>
            {
                this.TimerStopped?.Invoke(this, e);
                this.StopBlinkTimer();
            };

            this.fasterButton.Click += (sender, e) => this.UpdateOffset(-1);
            this.slowerButton.Click += (sender, e) => this.UpdateOffset(1);
        }

        private void SetInputControlEnabled(bool enabled)
        {
            this.initSeedTextBox.Enabled = enabled;
            this.minUpDown.Enabled = enabled;
            this.maxUpDown.Enabled = enabled;
            this.targetAdvUpDown.Enabled = enabled;
        }

        private async Task BlinkSearch()
        {
            var intervals = this.blinkObserveControl.GetIntervals();
            if (!intervals.Any())
                return;

            var timer = new Stopwatch();
            timer.Restart();
            var startTime = (double)timer.ElapsedMilliseconds;
            var initSeed = uint.Parse(this.initSeedTextBox.Text, NumberStyles.HexNumber);
            var min = (uint)this.minUpDown.Value;
            var max = (uint)this.maxUpDown.Value;
            var targetAdv = (int)this.targetAdvUpDown.Value;

            if (IndexFinder.TryGetIndex(initSeed, min, max, intervals, out uint resIndex))
            {
                var seed = initSeed.TinyMT();
                resIndex += (uint)intervals.Length;
                targetAdv -= (int)resIndex;
                if (this.useTimerCheckBox.Checked && targetAdv > 0)
                    seed.Advance(resIndex - 1); // 最後に一致した乱数列から瞬き間隔を取得したいので

                else
                {
                    seed.Advance(resIndex);
                    this.currentAdvUpDown.Value = resIndex;
                    this.UpdateStateBox(seed);
                    return;
                }

                var q = new Queue<(int interval, (uint, uint, uint, uint) seed)>(targetAdv);
                var prev = 0;
                // 経過時間を累積していく
                for (var i = 0; i < targetAdv; i++)
                {
                    var interval = seed.GetInterval_Pokemon() + prev;
                    q.Enqueue((interval, seed));
                    prev = interval;
                }

                this.TimerStartRequest();
                await this.StartBlinkTimer(timer, startTime, resIndex, q);
                this.TimerStopRequest();
            }
        }

        private async Task StartBlinkTimer(Stopwatch timer, double baseTime, uint currentIndex, Queue<(int interval, (uint S0, uint S1, uint S2, uint S3) seed)> timeLine)
        {
            var last = timeLine.Last().interval;
            var frameTime = 1000.0 / this.fps;
            var updateTime = baseTime + frameTime; // 1Fごとに更新したい
            var seed = default((uint, uint, uint, uint));
            var frameCount = 0;

            await Task.Run(() =>
            {
                while (!this.tokenSource.IsCancellationRequested && timeLine.TryDequeue(out var result))
                {
                    seed = result.seed;
                    var interval = result.interval;
                    this.Invoke(() =>
                    {
                        this.currentAdvUpDown.Value = currentIndex;
                        this.UpdateStateBox(seed);
                        this.UpdateNextInterval(timeLine.Count > 0 ? timeLine.Peek().interval - interval : 0);
                    });

                    while (!this.tokenSource.IsCancellationRequested)
                    {
                        if ((double)timer.ElapsedMilliseconds >= updateTime)
                        {
                            frameCount++;
                            updateTime += frameTime;
                            var _frameCount = frameCount + this.offset;
                            this.Invoke(() =>
                            {
                                this.UpdateInterval(interval - _frameCount);
                                this.UpdateRemainingTime(last - _frameCount);
                            });
                            if (interval - _frameCount <= 0)
                            {
                                this.BlinkSound.Play();
                                currentIndex++;
                                break;
                            }
                        }
                        Thread.Sleep(1);
                    }
                }
            });
            if (timeLine.Count == 0)
            {
                this.currentAdvUpDown.Value = currentIndex;
                this.UpdateStateBox(seed.Advance());
            }
        }

        private void StopBlinkTimer()
        {
            this.tokenSource?.Cancel();
            this.tokenSource?.Dispose();
        }

        private void UpdateStateBox((uint S0, uint S1, uint S2, uint S3) seed)
        {
            this.state0Box.Text = $"{seed.S0:X8}";
            this.state1Box.Text = $"{seed.S1:X8}";
            this.state2Box.Text = $"{seed.S2:X8}";
            this.state3Box.Text = $"{seed.S3:X8}";
        }

        private void UpdateRemainingTime(long interval) => this.remainingTimeLabel.Text = $"{interval / this.fps:F2}";

        private void UpdateInterval(int interval) => this.intervalLabel.Text = $"{interval / this.fps:F2}";

        private void UpdateNextInterval(int interval) => this.nextIntervalLabel.Text = $"{interval / this.fps:F2}";

        private void UpdateOffset(int offset)
        {
            this.offset += offset;
            this.offsetLabel.Text = this.offset == 0 ? "" : $"{this.offset:+0;-0}";
        }

        private void TimerStartRequest()
        {
            this.timerStopButton.Enabled = true;
            this.timerStopButton.Text = "停止";
            this.slowerButton.Enabled = true;
            this.fasterButton.Enabled = true;
        }

        private void TimerStopRequest()
        {
            this.timerStopButton.Enabled = false;
            this.timerStopButton.Text = "待機中";
            this.slowerButton.Enabled = false;
            this.fasterButton.Enabled = false;
            this.UpdateOffset(0);
            this.tokenSource = new();
        }
    }
}
