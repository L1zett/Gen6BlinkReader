using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen6BlinkReader.Subforms
{
    public partial class SettingForm : Form
    {
        private readonly string sourceDir = "./source";
        private Dictionary<Control, int> snapShots = new();

        public string ImgPath => Path.Combine(this.sourceDir, this.imgPathComboBox.Text);

        public int DisplayScale => (int)this.displayScaleUpDown.Value;

        public int Threads => (int)this.threadsUpDown.Value;


        public SettingForm()
        {
            InitializeComponent();
            this.LoadImgPathComboBox();
            this.threadsUpDown.Value = this.threadsUpDown.Maximum = Environment.ProcessorCount;
            this.okButton.Click += (sender, e) => this.SnapShotValue();
            this.cancelButton.Click += (sender, e) => this.Undo();
            this.Load += (sender, e) => this.SnapShotValue();
        }

        private void LoadImgPathComboBox()
        {
            if (!Directory.Exists(this.sourceDir))
                Directory.CreateDirectory(this.sourceDir);

            var fileNames = Directory.GetFiles(this.sourceDir, "*.png").Select(Path.GetFileName).ToArray();
            if (fileNames.Any())
            {
                this.imgPathComboBox.Items.AddRange(fileNames);
                this.imgPathComboBox.SelectedIndex = 0;
            }
        }

        private void SnapShotValue()
        {
            this.snapShots[this.imgPathComboBox] = this.imgPathComboBox.SelectedIndex;
            this.snapShots[this.displayScaleUpDown] = this.DisplayScale;
            this.snapShots[this.threadsUpDown] = this.Threads;
        }

        private void Undo()
        {
            this.imgPathComboBox.SelectedIndex = this.snapShots[this.imgPathComboBox];
            this.displayScaleUpDown.Value = this.snapShots[this.displayScaleUpDown];
            this.threadsUpDown.Value = this.snapShots[this.threadsUpDown];
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.Undo();
        }
    }
}
