using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gen6BlinkReader
{
    public class HexTextBox : TextBox
    {
        public HexTextBox()
        {
            this.MaxLength = 8;
            this.TextChanged += HexTextBox_TextChanged;
        }

        private void HexTextBox_TextChanged(object sender, EventArgs e)
        {
            var validText = new string(this.Text.Where(Uri.IsHexDigit).ToArray());
            if (this.Text != validText)
            {
                this.Text = validText;
                this.SelectionStart = this.Text.Length;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == '\b')
                return;

            if (ModifierKeys.HasFlag(Keys.Control) || ModifierKeys.HasFlag(Keys.Shift))
                return;

            if (!Uri.IsHexDigit(e.KeyChar))
                e.Handled = true;
        }
    }

}
