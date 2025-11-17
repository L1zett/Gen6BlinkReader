using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlinkReader;
using BlinkReader.Forms;
using Gen6BlinkReader;

namespace Gen6BlinkReader.Main
{
    public partial class BlinkObserveControl : UserControl
    {
        private bool isObserving = false;
        private List<int> intervalList = new List<int>();
        private CancellationTokenSource tokenSource = new();
        private SoundPlayer BlinkSound;
        private CaptureWindowForm captureWindowForm;
        private Settings settings;
        public event EventHandler? StartButtonClick;
        public event EventHandler? StopButtonClick;
        public event EventHandler? ObserveCompleted;

        public int ObserveCount => (int)observeCountUpDown.Value;

        public BlinkObserveControl()
        {
            InitializeComponent();
            this.startButton.Click += async (sender, e) => await this.BlinkObserveAsync();
            // ソートできないようにする
            foreach (DataGridViewColumn c in this.intervalListGridView.Columns)
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void Init(CaptureWindowForm captureWindowForm, Settings settings)
        {
            this.captureWindowForm = captureWindowForm;
            this.settings = settings;
        }

        public async Task BlinkObserveAsync()
        {
            if (!this.isObserving)
            {
                this.StartRequest();
                var count = this.ObserveCount;
                long TPF = (long)(10_000_000 / 60);
                var detector = new BlinkDetector(settings.ImgPath);
                var en = BlinkCapturerer.CaptureBlinkAsync(this.tokenSource.Token, detector, this.captureWindowForm);
                long prev = 0;
                await foreach (var interval in en)
                {
                    Console.Beep();
                    this.AddInterval((int)((interval - prev) / TPF));
                    if (count <= this.intervalList.Count())
                    {
                        this.ObserveComplete();
                        return;
                    }
                    prev = interval;
                }
                this.StopRequestRecieved();
            }
            else
            {
                this.tokenSource.Cancel();
                this.tokenSource.Dispose();
                this.tokenSource = new();
            }
        }

        private void AddInterval(int interval)
        {
            var count = this.intervalListGridView.Rows.Count;
            if (count != 0)
            {
                this.intervalListGridView.Rows.Add($"{interval}");
                this.intervalList.Add(interval);
                this.intervalListGridView.FirstDisplayedScrollingRowIndex = this.intervalList.Count;
            }
            else
            {
                this.intervalListGridView.Rows.Add("---");
            }
        }

        private void StartRequest()
        {
            this.intervalList.Clear();
            this.intervalListGridView.Rows.Clear();
            this.StartButtonClick?.Invoke(this, EventArgs.Empty);
            this.isObserving = true;
            this.startButton.Text = "Stop";
        }

        private void StopRequestRecieved()
        {
            this.StopButtonClick?.Invoke(this, EventArgs.Empty);
            this.isObserving = false;
            this.startButton.Text = "Start";
        }

        private void ObserveComplete()
        {
            this.ObserveCompleted?.Invoke(this, EventArgs.Empty);
            this.isObserving = false;
            this.startButton.Text = "Start";
        }

        public void SetStartButtonEnabled(bool enabled) => this.startButton.Enabled = enabled;

        public int[] GetIntervals() => this.intervalList.ToArray();
    }
}
