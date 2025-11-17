using System.ComponentModel;
using BlinkReader;
using BlinkReader.Forms;
using Gen6BlinkReader.Subforms;


namespace Gen6BlinkReader.Main
{
    public partial class MainForm : Form
    {
        private readonly double fps = 59.8261;
        private bool isCapturing = false;
        private BindingList<RNGResult> RNGResults = new();
        private CaptureWindowForm captureWindowForm = new();
        private CaptureTestForm captureTestForm = new();
        private SettingForm settingForm = new();
        private CancellationTokenSource tokenSource = new();
        private Settings settings;

        public MainForm()
        {
            InitializeComponent();
            this.InitializeSettings();
            this.InitializeControlEvents();
        }

        private void InitializeControlEvents()
        {
            this.captureWindowForm.FormClosing += (sender, e) => this.captureFrameButton_Click(this, EventArgs.Empty);
            this.captureTestForm.FormClosing += (sender, e) => this.captureTestButton_Click(this, EventArgs.Empty);
            this.saveCaptureButton.Click += (sender, e) => this.SaveCapture();

            this.seedSearchControl.Init(this.captureWindowForm, this.settings);
            this.seedSearchControl.ObserveStarted += (sender, e) => this.DisableCaptureFrameOther();
            this.seedSearchControl.ObserveStopRequested += (sender, e) => this.EnableMenuButton();
            this.seedSearchControl.ObserveCompleted += (sender, e) => this.EnableMenuButton();

            this.blinkSearchControl.Init(this.captureWindowForm, this.settings);
            this.blinkSearchControl.ObserveStarted += (sender, e) => this.DisableCaptureFrameOther();
            this.blinkSearchControl.ObserveStopRequested += (sender, e) => this.EnableMenuButton();
            this.blinkSearchControl.ObserveCompleted += (sender, e) => this.EnableMenuButton();

            this.ResizeEnd += (sender, e) =>
            {
                this.Invalidate();
                this.PerformLayout();
            };
        }

        protected override void OnResize(EventArgs e)
        {

        }

        private void InitializeSettings()
        {
            this.settings = new Settings(
                this.settingForm.ImgPath,
                this.settingForm.Threads
            );
        }

        private void DisableCaptureFrameOther()
        {
            // キャプチャ枠表示以外のメニューボタンは使用不可にする
            foreach (ToolStripItem item in this.menuStrip.Items)
                item.Enabled = item == this.captureFrameButton;
        }

        private void EnableMenuButton()
        {
            foreach (ToolStripItem item in menuStrip.Items)
                item.Enabled = true;
        }


        private void captureFrameButton_Click(object sender, EventArgs e)
        {
            if (!this.captureWindowForm.Visible)
            {
                this.captureFrameButton.Text = "キャプチャ枠非表示";
                this.captureWindowForm.Show();
            }
            else
            {
                this.captureFrameButton.Text = "キャプチャ枠表示";
                this.captureWindowForm.Hide();
            }
        }

        private void captureTestButton_Click(object sender, EventArgs e)
        {
            if (!this.isCapturing)
            {
                this.captureTestButton.Text = "キャプチャテスト停止";
                this.captureTestForm.Show();
                this.StartCaptureTest();
                this.seedSearchControl.SetControlEnabled(false);
            }
            else
            {
                this.captureTestButton.Text = "キャプチャテスト開始";
                this.captureTestForm.Hide();
                this.CancelCapture();
                this.seedSearchControl.SetControlEnabled(true);
            }
        }

        private async void StartCaptureTest()
        {
            this.isCapturing = true;
            var detector = new BlinkDetector(this.settings.ImgPath);
            var en = BlinkCapturerer.CaptureBlinkTestAsync(this.tokenSource.Token, detector, this.captureWindowForm, this.fps);
            await foreach (var blinking in en)
                this.captureTestForm.SetBlink(blinking);
        }

        private void CancelCapture()
        {
            this.isCapturing = false;
            this.tokenSource.Cancel();
            this.tokenSource.Dispose();
            this.tokenSource = new();
        }

        private void SaveCapture()
        {
            var bmp = this.captureWindowForm.CaptureScreen();
            var fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.png";
            bmp.Save(fileName);
            bmp.Dispose();
            MessageBox.Show(
                $"画像を保存しました。\n{fileName}",
                "保存完了",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            if (this.settingForm.ShowDialog() == DialogResult.OK)
            {
                this.settings.ImgPath = this.settingForm.ImgPath;
                this.settings.Threads = this.settingForm.Threads;
                CaptureWindowForm.DisplayScale = this.settingForm.DisplayScale;
            }
        }
    }

    public class Settings(string imgPath, int threads)
    {
        public string ImgPath { get; set; } = imgPath;
        public int Threads { get; set; } = threads;
    }
}
