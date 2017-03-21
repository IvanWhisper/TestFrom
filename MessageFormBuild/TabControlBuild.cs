using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraTab;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace MessageFormBuild
{
    public class TabControlBuild
    {
        XtraTabControl xTabControl;
        DataGridView dgv = new DataGridView();
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="xTabControl"></param>
        public TabControlBuild(XtraTabControl xTabControl)
        {
            this.xTabControl = xTabControl;
            //datagridview单元格值转化事件注册
            dgv.CellFormatting += Dgv_CellFormatting;
        }
        /// <summary>
        /// TabControls加载TabPage标签
        /// </summary>
        /// <param name="dt"></param>
        public void BuildingTabControl(DataTable dt)
        {
            List<string> ls = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ls.Add(dt.Rows[i]["send_system"].ToString());
            }
            List<string> lss = ls.Distinct().ToList();
            xTabControl.TabPages.Clear();
            foreach (string nm in lss)
            {
                XtraTabPage xTabPage = new XtraTabPage();
                xTabPage.Text = nm;
                xTabControl.TabPages.Add(xTabPage);
            }
        }
        /// <summary>
        /// 标签选择改变
        /// </summary>
        /// <param name="dt"></param>
        public void TabPageChange(DataTable dt)
        {
            if (xTabControl.TabPages.Count > 0)
            {
                if (xTabControl.SelectedTabPage.Controls.Count > 0) { xTabControl.SelectedTabPage.Controls.Clear(); }
                DataView view = new DataView();
                view = dt.DefaultView;
                view.RowFilter = string.Format("send_system = '{0}'", xTabControl.SelectedTabPage.Text);
                dgv.DataSource = view.ToTable();
                Label lab = new Label();
                lab.Text = string.Format("  {0}消息", xTabControl.SelectedTabPage.Text);
                lab.AutoSize = false;
                lab.Font = new Font("微软雅黑", 12, FontStyle.Bold);
                lab.TextAlign = ContentAlignment.MiddleLeft;
                TableLayoutPanel tlp = new TableLayoutPanel();
                tlp.RowCount = 2;
                tlp.ColumnCount = 1;
                tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
                tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
                tlp.Controls.Add(lab, 0, 0);
                tlp.Controls.Add(dgv, 0, 1);
                xTabControl.SelectedTabPage.Controls.Clear();
                xTabControl.SelectedTabPage.Controls.Add(tlp);
                lab.Dock = DockStyle.Fill;
                DataGridViewSetting.SettingDataGridview(dgv);
                tlp.Dock = DockStyle.Fill;
            }
        }
        /// <summary>
        /// 格式化单元格值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 /*绑定数据源中列的序号*/)
            {
                //  MessageBox.Show(e.Value.ToString());
                if (e.Value.ToString().Equals("1"))
                {
                    e.Value = "●";
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font=new Font("幼圆",8);
                }
                else
                {
                    e.Value = "";
                }

            }

        }
    }
}
