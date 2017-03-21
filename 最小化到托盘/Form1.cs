using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormHelper;
using FormHelper.Interface;


namespace 最小化到托盘
{
    public partial class Form1 : Form
    {
        //NotifyIcon notifyIcon = new NotifyIcon();
        //ContextMenuStrip notifyMenu = new ContextMenuStrip();
        demonotifymenu dn;
        MiniToTray mtt;
        string ico;
        public Form1()
        {
            InitializeComponent();

            ico = Application.StartupPath + @"\img\" + 44 + ".ico";
            dn = new demonotifymenu(this);

            mtt = new MiniToTray(this, ico, dn);


            //this.FormClosing += Form1_FormClosing;
            //this.SizeChanged += Form1_SizeChanged;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            ////throw new NotImplementedException();
            ////判断是否选择的是最小化按钮
            //if (WindowState == FormWindowState.Minimized)
            //{
            //    //隐藏任务栏区图标
            //    this.ShowInTaskbar = false;
            //    //图标显示在托盘区
            //    notifyIcon.Visible = true;
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ////throw new NotImplementedException();
            //if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //{
            //    // 关闭所有的线程
            //    this.Dispose();
            //    this.Close();
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bitmap b = new Bitmap(Application.StartupPath + @"\img\" + 44 + ".ico");
            //pictureBox1.Image = b;

            //notifyIcon.Icon = new Icon(Application.StartupPath + @"\img\" + 44 + ".ico");
            //notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;

            //notifyMenu.Items.Add("显示");
            //notifyMenu.Items.Add("退出");
            //notifyMenu.ItemClicked += NotifyMenu_ItemClicked;
            //notifyIcon.ContextMenuStrip = notifyMenu;

        }

        private void NotifyMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ////throw new NotImplementedException();
            //if(e.ClickedItem.Text== "显示")
            //{
            //    WindowState = FormWindowState.Normal;
            //}
            //else
            //{
            //    if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //    {
            //        // 关闭所有的线程
            //        this.Dispose();
            //        this.Close();
            //    }
            //}
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           //// throw new NotImplementedException();
           // if (WindowState == FormWindowState.Minimized)
           // {
           //     //还原窗体显示    
           //     WindowState = FormWindowState.Normal;
           //     //激活窗体并给予它焦点
           //     this.Activate();
           //     //任务栏区显示图标
           //     this.ShowInTaskbar = true;
           //     //托盘区图标隐藏
           //     notifyIcon.Visible = false;
           // }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Close();
        }
    }
}
