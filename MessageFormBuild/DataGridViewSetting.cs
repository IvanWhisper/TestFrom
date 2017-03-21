using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MessageFormBuild
{
     class DataGridViewSetting
    {
        /// <summary>
        /// 对于DataGridView设置格式
        /// </summary>
        /// <param name="dgv"></param>
        public static void SettingDataGridview(DataGridView dgv)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.Columns[0].Width = dgv.Width / 18;
            dgv.Columns[1].Width = dgv.Width / 5;
            dgv.Columns[3].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

        }

    }
}
