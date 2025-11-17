

namespace Gen6BlinkReader.Main
{
    partial class SeedSearchControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            searchGroupBox = new GroupBox();
            upperUpDown = new NumericUpDown();
            lowerUpDown = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            baseSeedRadioButton = new RadioButton();
            bruteForceRadioButton = new RadioButton();
            label1 = new Label();
            baseSeedTextBox = new HexTextBox();
            blinkObserveControl = new BlinkObserveControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            cancelButton = new Button();
            searchButton = new Button();
            resultGridView = new MyDataGridView();
            flowLayoutPanel1.SuspendLayout();
            searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upperUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowerUpDown).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultGridView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(searchGroupBox);
            flowLayoutPanel1.Controls.Add(blinkObserveControl);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(273, 535);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // searchGroupBox
            // 
            searchGroupBox.Anchor = AnchorStyles.None;
            searchGroupBox.Controls.Add(upperUpDown);
            searchGroupBox.Controls.Add(lowerUpDown);
            searchGroupBox.Controls.Add(label3);
            searchGroupBox.Controls.Add(label2);
            searchGroupBox.Controls.Add(baseSeedRadioButton);
            searchGroupBox.Controls.Add(bruteForceRadioButton);
            searchGroupBox.Controls.Add(label1);
            searchGroupBox.Controls.Add(baseSeedTextBox);
            searchGroupBox.Location = new Point(3, 3);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(264, 139);
            searchGroupBox.TabIndex = 0;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "検索条件";
            // 
            // upperUpDown
            // 
            upperUpDown.Location = new Point(166, 105);
            upperUpDown.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            upperUpDown.Name = "upperUpDown";
            upperUpDown.Size = new Size(71, 23);
            upperUpDown.TabIndex = 9;
            upperUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // lowerUpDown
            // 
            lowerUpDown.Location = new Point(69, 105);
            lowerUpDown.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            lowerUpDown.Name = "lowerUpDown";
            lowerUpDown.Size = new Size(71, 23);
            lowerUpDown.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 108);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 6;
            label3.Text = "～";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 108);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "消費数";
            // 
            // baseSeedRadioButton
            // 
            baseSeedRadioButton.AutoSize = true;
            baseSeedRadioButton.Checked = true;
            baseSeedRadioButton.Location = new Point(9, 47);
            baseSeedRadioButton.Name = "baseSeedRadioButton";
            baseSeedRadioButton.Size = new Size(116, 19);
            baseSeedRadioButton.TabIndex = 3;
            baseSeedRadioButton.TabStop = true;
            baseSeedRadioButton.Text = "基準seedから検索";
            baseSeedRadioButton.UseVisualStyleBackColor = true;
            // 
            // bruteForceRadioButton
            // 
            bruteForceRadioButton.AutoSize = true;
            bruteForceRadioButton.Location = new Point(9, 22);
            bruteForceRadioButton.Name = "bruteForceRadioButton";
            bruteForceRadioButton.Size = new Size(61, 19);
            bruteForceRadioButton.TabIndex = 2;
            bruteForceRadioButton.Text = "全探索";
            bruteForceRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 80);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "基準seed";
            // 
            // baseSeedTextBox
            // 
            baseSeedTextBox.Location = new Point(69, 77);
            baseSeedTextBox.MaxLength = 8;
            baseSeedTextBox.Name = "baseSeedTextBox";
            baseSeedTextBox.Size = new Size(91, 23);
            baseSeedTextBox.TabIndex = 0;
            // 
            // blinkObserveControl
            // 
            blinkObserveControl.Location = new Point(3, 148);
            blinkObserveControl.Name = "blinkObserveControl";
            blinkObserveControl.Size = new Size(264, 314);
            blinkObserveControl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel1.Controls.Add(searchButton, 0, 0);
            tableLayoutPanel1.Location = new Point(36, 468);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(198, 42);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.Location = new Point(111, 9);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "キャンセル";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.None;
            searchButton.Location = new Point(12, 9);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "検索";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // resultGridView
            // 
            resultGridView.AllowUserToAddRows = false;
            resultGridView.AllowUserToDeleteRows = false;
            resultGridView.AllowUserToResizeColumns = false;
            resultGridView.AllowUserToResizeRows = false;
            resultGridView.BackgroundColor = SystemColors.ControlLight;
            resultGridView.BorderStyle = BorderStyle.Fixed3D;
            resultGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            resultGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            resultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultGridView.Dock = DockStyle.Fill;
            resultGridView.Location = new Point(273, 0);
            resultGridView.Name = "resultGridView";
            resultGridView.ReadOnly = true;
            resultGridView.RowHeadersVisible = false;
            resultGridView.Size = new Size(707, 535);
            resultGridView.TabIndex = 5;
            // 
            // SeedSearchControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resultGridView);
            Controls.Add(flowLayoutPanel1);
            Name = "SeedSearchControl";
            Size = new Size(980, 535);
            flowLayoutPanel1.ResumeLayout(false);
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)upperUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowerUpDown).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox searchGroupBox;
        private NumericUpDown upperUpDown;
        private NumericUpDown lowerUpDown;
        private Label label3;
        private Label label2;
        private RadioButton baseSeedRadioButton;
        private RadioButton bruteForceRadioButton;
        private Label label1;
        private HexTextBox baseSeedTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button cancelButton;
        private Button searchButton;
        private MyDataGridView resultGridView;
        private BlinkObserveControl blinkObserveControl;
    }
}
