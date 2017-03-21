using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程序单例运行与重新启动
{
    public partial class Form2 : Form
    {
        public Form2()
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
            System.Windows.Forms.Application.Restart(); //重启当前程序
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
