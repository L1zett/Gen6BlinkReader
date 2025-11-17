using System.ComponentModel;

namespace Gen6BlinkReader.Main
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            seedSearchPage = new TabPage();
            seedSearchControl = new SeedSearchControl();
            blinkSearchPage = new TabPage();
            blinkSearchControl = new BlinkSearchControl();
            captureFrameButton = new ToolStripMenuItem();
            saveCaptureButton = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            captureTestButton = new ToolStripMenuItem();
            settingButton = new ToolStripMenuItem();
            tabControl.SuspendLayout();
            seedSearchPage.SuspendLayout();
            blinkSearchPage.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(seedSearchPage);
            tabControl.Controls.Add(blinkSearchPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 24);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(628, 558);
            tabControl.TabIndex = 1;
            // 
            // seedSearchPage
            // 
            seedSearchPage.Controls.Add(seedSearchControl);
            seedSearchPage.Location = new Point(4, 24);
            seedSearchPage.Name = "seedSearchPage";
            seedSearchPage.Padding = new Padding(3);
            seedSearchPage.Size = new Size(620, 530);
            seedSearchPage.TabIndex = 0;
            seedSearchPage.Text = "seed検索";
            seedSearchPage.UseVisualStyleBackColor = true;
            // 
            // seedSearchControl
            // 
            seedSearchControl.Dock = DockStyle.Fill;
            seedSearchControl.Location = new Point(3, 3);
            seedSearchControl.Name = "seedSearchControl";
            seedSearchControl.Size = new Size(614, 524);
            seedSearchControl.TabIndex = 0;
            // 
            // blinkSearchPage
            // 
            blinkSearchPage.Controls.Add(blinkSearchControl);
            blinkSearchPage.Location = new Point(4, 24);
            blinkSearchPage.Name = "blinkSearchPage";
            blinkSearchPage.Padding = new Padding(3);
            blinkSearchPage.Size = new Size(620, 530);
            blinkSearchPage.TabIndex = 1;
            blinkSearchPage.Text = "瞬き検索";
            blinkSearchPage.UseVisualStyleBackColor = true;
            // 
            // blinkSearchControl
            // 
            blinkSearchControl.Dock = DockStyle.Fill;
            blinkSearchControl.Location = new Point(3, 3);
            blinkSearchControl.Name = "blinkSearchControl";
            blinkSearchControl.Size = new Size(614, 524);
            blinkSearchControl.TabIndex = 0;
            // 
            // captureFrameButton
            // 
            captureFrameButton.Name = "captureFrameButton";
            captureFrameButton.Size = new Size(97, 20);
            captureFrameButton.Text = "キャプチャ枠表示";
            captureFrameButton.Click += captureFrameButton_Click;
            // 
            // saveCaptureButton
            // 
            saveCaptureButton.Name = "saveCaptureButton";
            saveCaptureButton.Size = new Size(76, 20);
            saveCaptureButton.Text = "画像を保存";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { captureFrameButton, captureTestButton, saveCaptureButton, settingButton });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(628, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // captureTestButton
            // 
            captureTestButton.Name = "captureTestButton";
            captureTestButton.Size = new Size(111, 20);
            captureTestButton.Text = "キャプチャテスト開始";
            captureTestButton.Click += captureTestButton_Click;
            // 
            // settingButton
            // 
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(43, 20);
            settingButton.Text = "設定";
            settingButton.Click += settingButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 582);
            Controls.Add(tabControl);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            seedSearchPage.ResumeLayout(false);
            blinkSearchPage.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl;
        private TabPage seedSearchPage;
        private TabPage blinkSearchPage;
        private ToolStripMenuItem captureFrameButton;
        private ToolStripMenuItem saveCaptureButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem settingButton;
        private ToolStripMenuItem captureTestButton;
        private SeedSearchControl seedSearchControl;
        private BlinkSearchControl blinkSearchControl;
    }
}
