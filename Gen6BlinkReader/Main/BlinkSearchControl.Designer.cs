namespace Gen6BlinkReader.Main
{
    partial class BlinkSearchControl
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
            groupBox1 = new GroupBox();
            maxUpDown = new NumericUpDown();
            label3 = new Label();
            minUpDown = new NumericUpDown();
            label2 = new Label();
            initSeedTextBox = new HexTextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            targetAdvUpDown = new NumericUpDown();
            useTimerCheckBox = new CheckBox();
            label15 = new Label();
            blinkObserveControl = new BlinkObserveControl();
            groupBox2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            fasterButton = new Button();
            slowerButton = new Button();
            timerStopButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            intervalLabel = new Label();
            label4 = new Label();
            remainingTimeLabel = new Label();
            label7 = new Label();
            label6 = new Label();
            nextIntervalLabel = new Label();
            offsetLabel = new Label();
            label10 = new Label();
            currentAdvUpDown = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            state3Box = new HexTextBox();
            state2Box = new HexTextBox();
            state1Box = new HexTextBox();
            state0Box = new HexTextBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minUpDown).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)targetAdvUpDown).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentAdvUpDown).BeginInit();
            groupBox3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(blinkObserveControl);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(273, 535);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(maxUpDown);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(minUpDown);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(initSeedTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 87);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "検索条件";
            // 
            // maxUpDown
            // 
            maxUpDown.Location = new Point(168, 52);
            maxUpDown.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            maxUpDown.Name = "maxUpDown";
            maxUpDown.Size = new Size(71, 23);
            maxUpDown.TabIndex = 5;
            maxUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 55);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 4;
            label3.Text = "～";
            // 
            // minUpDown
            // 
            minUpDown.Location = new Point(69, 52);
            minUpDown.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            minUpDown.Name = "minUpDown";
            minUpDown.Size = new Size(71, 23);
            minUpDown.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "消費数";
            // 
            // initSeedTextBox
            // 
            initSeedTextBox.Location = new Point(69, 24);
            initSeedTextBox.MaxLength = 8;
            initSeedTextBox.Name = "initSeedTextBox";
            initSeedTextBox.Size = new Size(91, 23);
            initSeedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 27);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "初期seed";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(targetAdvUpDown);
            groupBox4.Controls.Add(useTimerCheckBox);
            groupBox4.Controls.Add(label15);
            groupBox4.Location = new Point(3, 96);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(264, 88);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "タイマーの設定";
            // 
            // targetAdvUpDown
            // 
            targetAdvUpDown.Anchor = AnchorStyles.Left;
            targetAdvUpDown.Location = new Point(84, 51);
            targetAdvUpDown.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            targetAdvUpDown.Name = "targetAdvUpDown";
            targetAdvUpDown.Size = new Size(76, 23);
            targetAdvUpDown.TabIndex = 1;
            targetAdvUpDown.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // useTimerCheckBox
            // 
            useTimerCheckBox.Anchor = AnchorStyles.Left;
            useTimerCheckBox.AutoSize = true;
            useTimerCheckBox.Location = new Point(9, 27);
            useTimerCheckBox.Name = "useTimerCheckBox";
            useTimerCheckBox.Size = new Size(154, 19);
            useTimerCheckBox.TabIndex = 4;
            useTimerCheckBox.Text = "検索終了時にタイマー起動";
            useTimerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Location = new Point(8, 55);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 0;
            label15.Text = "目標消費数:";
            // 
            // blinkObserveControl
            // 
            blinkObserveControl.Location = new Point(3, 190);
            blinkObserveControl.Name = "blinkObserveControl";
            blinkObserveControl.Size = new Size(264, 314);
            blinkObserveControl.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Location = new Point(279, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 194);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "タイマー";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4266548F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.14669F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4266548F));
            tableLayoutPanel4.Controls.Add(fasterButton, 0, 0);
            tableLayoutPanel4.Controls.Add(slowerButton, 2, 0);
            tableLayoutPanel4.Controls.Add(timerStopButton, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(3, 160);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(324, 31);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // fasterButton
            // 
            fasterButton.Anchor = AnchorStyles.Right;
            fasterButton.Enabled = false;
            fasterButton.Location = new Point(22, 4);
            fasterButton.Name = "fasterButton";
            fasterButton.Size = new Size(96, 23);
            fasterButton.TabIndex = 2;
            fasterButton.Text = "◀◀";
            fasterButton.UseVisualStyleBackColor = true;
            // 
            // slowerButton
            // 
            slowerButton.Anchor = AnchorStyles.Left;
            slowerButton.Enabled = false;
            slowerButton.Location = new Point(205, 4);
            slowerButton.Name = "slowerButton";
            slowerButton.Size = new Size(96, 23);
            slowerButton.TabIndex = 1;
            slowerButton.Text = "▶▶";
            slowerButton.UseVisualStyleBackColor = true;
            // 
            // timerStopButton
            // 
            timerStopButton.Anchor = AnchorStyles.None;
            timerStopButton.Enabled = false;
            timerStopButton.Location = new Point(124, 4);
            timerStopButton.Name = "timerStopButton";
            timerStopButton.Size = new Size(75, 23);
            timerStopButton.TabIndex = 3;
            timerStopButton.Text = "待機中";
            timerStopButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(intervalLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(remainingTimeLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(label6, 1, 2);
            tableLayoutPanel2.Controls.Add(nextIntervalLabel, 1, 3);
            tableLayoutPanel2.Controls.Add(offsetLabel, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.83582F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 67.16418F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.Size = new Size(324, 136);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // intervalLabel
            // 
            intervalLabel.Anchor = AnchorStyles.None;
            intervalLabel.AutoSize = true;
            intervalLabel.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            intervalLabel.Location = new Point(47, 97);
            intervalLabel.Name = "intervalLabel";
            intervalLabel.Size = new Size(68, 37);
            intervalLabel.TabIndex = 2;
            intervalLabel.Text = "0.00";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "残り時間:";
            // 
            // remainingTimeLabel
            // 
            remainingTimeLabel.Anchor = AnchorStyles.None;
            remainingTimeLabel.AutoSize = true;
            remainingTimeLabel.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            remainingTimeLabel.Location = new Point(36, 26);
            remainingTimeLabel.Name = "remainingTimeLabel";
            remainingTimeLabel.Size = new Size(90, 50);
            remainingTimeLabel.TabIndex = 2;
            remainingTimeLabel.Text = "0.00";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 81);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 3;
            label7.Text = "Interval:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(165, 81);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 4;
            label6.Text = "Next:";
            // 
            // nextIntervalLabel
            // 
            nextIntervalLabel.Anchor = AnchorStyles.None;
            nextIntervalLabel.AutoSize = true;
            nextIntervalLabel.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nextIntervalLabel.Location = new Point(209, 97);
            nextIntervalLabel.Name = "nextIntervalLabel";
            nextIntervalLabel.Size = new Size(68, 37);
            nextIntervalLabel.TabIndex = 5;
            nextIntervalLabel.Text = "0.00";
            // 
            // offsetLabel
            // 
            offsetLabel.Anchor = AnchorStyles.None;
            offsetLabel.AutoSize = true;
            offsetLabel.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            offsetLabel.Location = new Point(243, 33);
            offsetLabel.Name = "offsetLabel";
            offsetLabel.Size = new Size(0, 37);
            offsetLabel.TabIndex = 6;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(9, 9);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 0;
            label10.Text = "消費数";
            // 
            // currentAdvUpDown
            // 
            currentAdvUpDown.Anchor = AnchorStyles.Left;
            currentAdvUpDown.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            currentAdvUpDown.Location = new Point(64, 5);
            currentAdvUpDown.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            currentAdvUpDown.Name = "currentAdvUpDown";
            currentAdvUpDown.ReadOnly = true;
            currentAdvUpDown.Size = new Size(100, 23);
            currentAdvUpDown.TabIndex = 1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(7, 43);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 2;
            label11.Text = "state[3]";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(171, 43);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 3;
            label12.Text = "state[2]";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Location = new Point(7, 78);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 4;
            label13.Text = "state[1]";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Location = new Point(171, 78);
            label14.Name = "label14";
            label14.Size = new Size(46, 15);
            label14.TabIndex = 5;
            label14.Text = "state[0]";
            // 
            // state3Box
            // 
            state3Box.Anchor = AnchorStyles.Left;
            state3Box.Location = new Point(64, 39);
            state3Box.MaxLength = 8;
            state3Box.Name = "state3Box";
            state3Box.Size = new Size(100, 23);
            state3Box.TabIndex = 6;
            // 
            // state2Box
            // 
            state2Box.Anchor = AnchorStyles.Left;
            state2Box.Location = new Point(224, 39);
            state2Box.MaxLength = 8;
            state2Box.Name = "state2Box";
            state2Box.Size = new Size(97, 23);
            state2Box.TabIndex = 7;
            // 
            // state1Box
            // 
            state1Box.Anchor = AnchorStyles.Left;
            state1Box.Location = new Point(64, 74);
            state1Box.MaxLength = 8;
            state1Box.Name = "state1Box";
            state1Box.Size = new Size(100, 23);
            state1Box.TabIndex = 8;
            // 
            // state0Box
            // 
            state0Box.Anchor = AnchorStyles.Left;
            state0Box.Location = new Point(224, 74);
            state0Box.MaxLength = 8;
            state0Box.Name = "state0Box";
            state0Box.Size = new Size(97, 23);
            state0Box.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel5);
            groupBox3.Location = new Point(279, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(330, 126);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "現在位置";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.8774223F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.8402367F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.863905F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.0344849F));
            tableLayoutPanel5.Controls.Add(state0Box, 3, 2);
            tableLayoutPanel5.Controls.Add(state1Box, 1, 2);
            tableLayoutPanel5.Controls.Add(label14, 2, 2);
            tableLayoutPanel5.Controls.Add(label13, 0, 2);
            tableLayoutPanel5.Controls.Add(label12, 2, 1);
            tableLayoutPanel5.Controls.Add(label10, 0, 0);
            tableLayoutPanel5.Controls.Add(state2Box, 3, 1);
            tableLayoutPanel5.Controls.Add(currentAdvUpDown, 1, 0);
            tableLayoutPanel5.Controls.Add(label11, 0, 1);
            tableLayoutPanel5.Controls.Add(state3Box, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Size = new Size(324, 104);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // BlinkSearchControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(flowLayoutPanel1);
            Name = "BlinkSearchControl";
            Size = new Size(618, 535);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minUpDown).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)targetAdvUpDown).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currentAdvUpDown).EndInit();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private NumericUpDown maxUpDown;
        private Label label3;
        private NumericUpDown minUpDown;
        private Label label2;
        private HexTextBox initSeedTextBox;
        private Label label1;
        private Main.BlinkObserveControl blinkObserveControl;
        private Label label15;
        private NumericUpDown targetAdvUpDown;
        private GroupBox groupBox2;
        private Label label10;
        private NumericUpDown currentAdvUpDown;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private HexTextBox state3Box;
        private HexTextBox state2Box;
        private HexTextBox state1Box;
        private HexTextBox state0Box;
        private TableLayoutPanel tableLayoutPanel4;
        private Button fasterButton;
        private Button slowerButton;
        private Button timerStopButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label intervalLabel;
        private Label label4;
        private Label remainingTimeLabel;
        private Label label7;
        private Label label6;
        private Label nextIntervalLabel;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox useTimerCheckBox;
        private Label offsetLabel;
    }
}
