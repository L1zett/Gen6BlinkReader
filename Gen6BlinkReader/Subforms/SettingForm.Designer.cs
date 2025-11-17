namespace Gen6BlinkReader.Subforms
{
    partial class SettingForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            imgPathComboBox = new ComboBox();
            label2 = new Label();
            displayScaleUpDown = new NumericUpDown();
            label3 = new Label();
            threadsUpDown = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            cancelButton = new Button();
            okButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)displayScaleUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)threadsUpDown).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.81924F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.18076F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(imgPathComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(displayScaleUpDown, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(threadsUpDown, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33361F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3331947F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3331947F));
            tableLayoutPanel1.Size = new Size(358, 107);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(48, 10);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "瞬き画像";
            // 
            // imgPathComboBox
            // 
            imgPathComboBox.Anchor = AnchorStyles.None;
            imgPathComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            imgPathComboBox.FormattingEnabled = true;
            imgPathComboBox.Location = new Point(129, 6);
            imgPathComboBox.Name = "imgPathComboBox";
            imgPathComboBox.Size = new Size(202, 23);
            imgPathComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(5, 45);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "ディスプレイスケール";
            // 
            // displayScaleUpDown
            // 
            displayScaleUpDown.Anchor = AnchorStyles.None;
            displayScaleUpDown.Increment = new decimal(new int[] { 25, 0, 0, 0 });
            displayScaleUpDown.Location = new Point(170, 41);
            displayScaleUpDown.Maximum = new decimal(new int[] { 225, 0, 0, 0 });
            displayScaleUpDown.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            displayScaleUpDown.Name = "displayScaleUpDown";
            displayScaleUpDown.ReadOnly = true;
            displayScaleUpDown.Size = new Size(120, 23);
            displayScaleUpDown.TabIndex = 3;
            displayScaleUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(47, 81);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "スレッド数";
            // 
            // threadsUpDown
            // 
            threadsUpDown.Anchor = AnchorStyles.None;
            threadsUpDown.Location = new Point(170, 77);
            threadsUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            threadsUpDown.Name = "threadsUpDown";
            threadsUpDown.ReadOnly = true;
            threadsUpDown.Size = new Size(120, 23);
            threadsUpDown.TabIndex = 5;
            threadsUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.Control;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel2.Controls.Add(okButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(5, 118);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(358, 38);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Left;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(182, 8);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 21);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "キャンセル";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Right;
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(101, 8);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 21);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 161);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(384, 200);
            MinimumSize = new Size(384, 200);
            Name = "SettingForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "設定";
            FormClosing += SettingForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)displayScaleUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)threadsUpDown).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox imgPathComboBox;
        private Label label2;
        private NumericUpDown displayScaleUpDown;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button cancelButton;
        private Button okButton;
        private NumericUpDown threadsUpDown;
    }
}