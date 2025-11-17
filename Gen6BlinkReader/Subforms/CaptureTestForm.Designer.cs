namespace Gen6BlinkReader.Subforms
{
    partial class CaptureTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FaceMarkBox = new TextBox();
            SuspendLayout();
            // 
            // FaceMarkBox
            // 
            FaceMarkBox.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 128);
            FaceMarkBox.Location = new Point(12, 12);
            FaceMarkBox.Name = "FaceMarkBox";
            FaceMarkBox.ReadOnly = true;
            FaceMarkBox.Size = new Size(167, 71);
            FaceMarkBox.TabIndex = 0;
            FaceMarkBox.Text = "( -ω- )";
            // 
            // CaptureTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 102);
            Controls.Add(FaceMarkBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CaptureTestForm";
            Text = "瞬きテスト";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FaceMarkBox;
    }
}