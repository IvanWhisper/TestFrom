using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormHelper.Interface;
using System.Windows.Forms;
using System.Drawing;

namespace 最小化到托盘
{
    class demonotifymenu : INotifyMenu
    {
        Form form;
        public demonotifymenu(Form form)
        {
            this.form=form;
        }
        public ToolStripItem[] toolStripItemrange()
        {
            ToolStripItem[] toolSitem = new ToolStripItem[2];
            //toolSitem[0]=new ToolStripMenuItem("显示");
            //toolSitem[1] = new ToolStripMenuItem("退出");
            string imgstr = Application.StartupPath + @"\img\" + 2 + ".ico";
            Image image1 = Image.FromFile(imgstr);
            toolSitem[0] = GetMenuItem("显示",image1);
            toolSitem[1] = GetMenuItem("图标2", image1);
            return toolSitem;
        }
        private ToolStripMenuItem GetMenuItem(string txt, Image img)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem();
            menuItem.Text = txt;
            menuItem.Image = img;
            return menuItem;
        }
        public void ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.ClickedItem.Text == "显示")
            {
                form.WindowState = FormWindowState.Normal;
                
            }
            else
            {
                if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // 关闭所有的线程
                    form.Dispose();
                    form.Close();
                }
            }

        }

    }
}
