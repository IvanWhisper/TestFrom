using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 最小化到托盘
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("要重新启动嘛？", "提示", MessageBoxButtons.YesNoCancel,
  MessageBoxIcon.Question) == DialogResult.Yes)

                System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);



        }

        private void button2_Click(object sender, EventArgs e)
        {
    
//c#实现程序自重启



//System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);  //重新开启当前程序
           // Close();//关闭当前程序

           
            System.Windows.Forms.Application.Restart(); //重启当前程序

        }
    }
}
