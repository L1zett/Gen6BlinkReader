using Gen6BlinkReader.CustomControl;

namespace Gen6BlinkReader.Main
{

    partial class BlinkObserveControl
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
            label1 = new Label();
            observeCountUpDown = new NumericUpDown();
            startButton = new Button();
            parentGroup = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            intervalListGridView = new ListGridView();
            intervalCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)observeCountUpDown).BeginInit();
            parentGroup.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)intervalListGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(5, 17);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "観測回数";
            // 
            // observeCountUpDown
            // 
            observeCountUpDown.Anchor = AnchorStyles.Left;
            observeCountUpDown.Location = new Point(66, 14);
            observeCountUpDown.Margin = new Padding(0);
            observeCountUpDown.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            observeCountUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            observeCountUpDown.Name = "observeCountUpDown";
            observeCountUpDown.Size = new Size(61, 23);
            observeCountUpDown.TabIndex = 1;
            observeCountUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.None;
            startButton.Location = new Point(28, 317);
            startButton.Name = "startButton";
            startButton.Size = new Size(211, 23);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            // 
            // parentGroup
            // 
            parentGroup.Controls.Add(tableLayoutPanel1);
            parentGroup.Dock = DockStyle.Fill;
            parentGroup.Location = new Point(0, 0);
            parentGroup.Name = "parentGroup";
            parentGroup.Size = new Size(274, 370);
            parentGroup.TabIndex = 3;
            parentGroup.TabStop = false;
            parentGroup.Text = "瞬きリスト";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(intervalListGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(startButton, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.16129F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.83871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.Size = new Size(268, 348);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(observeCountUpDown);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 47);
            panel1.TabIndex = 3;
            // 
            // intervalListGridView
            // 
            intervalListGridView.AllowUserToAddRows = false;
            intervalListGridView.AllowUserToDeleteRows = false;
            intervalListGridView.AllowUserToResizeColumns = false;
            intervalListGridView.AllowUserToResizeRows = false;
            intervalListGridView.Anchor = AnchorStyles.None;
            intervalListGridView.BackgroundColor = SystemColors.ControlLight;
            intervalListGridView.BorderStyle = BorderStyle.Fixed3D;
            intervalListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            intervalListGridView.Columns.AddRange(new DataGridViewColumn[] { intervalCol });
            intervalListGridView.Location = new Point(14, 56);
            intervalListGridView.Name = "intervalListGridView";
            intervalListGridView.ReadOnly = true;
            intervalListGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            intervalListGridView.Size = new Size(240, 244);
            intervalListGridView.TabIndex = 1;
            // 
            // intervalCol
            // 
            intervalCol.HeaderText = "Interval";
            intervalCol.Name = "intervalCol";
            intervalCol.ReadOnly = true;
            // 
            // BlinkObserveControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parentGroup);
            Name = "BlinkObserveControl";
            Size = new Size(274, 370);
            ((System.ComponentModel.ISupportInitialize)observeCountUpDown).EndInit();
            parentGroup.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)intervalListGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private NumericUpDown observeCountUpDown;
        private Button startButton;
        private GroupBox parentGroup;
        private ListGridView intervalListGridView;
        private DataGridViewTextBoxColumn intervalCol;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}