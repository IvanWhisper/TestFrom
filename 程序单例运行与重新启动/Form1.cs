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
    public partial class Form1 : Form
    {
        Form2 sa;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //设置Form2窗体实例只能是一个，即_form2
            if (sa == null || sa.IsDisposed)
            {
                sa = new Form2();
            }
            if (!sa.Created)
            {
                sa.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
