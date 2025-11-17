using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen6BlinkReader.Subforms
{
    public partial class CaptureTestForm : Form
    {
        public CaptureTestForm()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => e.Cancel = true;
        }

        public void SetBlink(bool blinking)
        {
            if (!blinking)
                this.FaceMarkBox.Text = "( -ω- )";
            else
                this.FaceMarkBox.Text = "(・ω・)";
        }
    }
}
