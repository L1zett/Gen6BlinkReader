using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen6BlinkReader.CustomControl
{
    public class ListGridView : DataGridView
    {
        public ListGridView()
        {
            var dgvtype = typeof(DataGridView);
            var dgvPropertyInfo = dgvtype.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            dgvPropertyInfo?.SetValue(this, true, null);
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            BackgroundColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.Fixed3D;
            ReadOnly = true;
            CellPainting += ListGridView_CellPainting;
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        private void ListGridView_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0 && 0 <= e.RowIndex)
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);

                TextRenderer.DrawText(
                    e.Graphics,
                    e.RowIndex.ToString(),
                    e.CellStyle.Font,
                    e.CellBounds,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }

        }
    }
}
