using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string value = InputBox.Input(窗口标题, 提示文本, 默认返回值);

            //只允许输入数字的InputBox调用：

            //string value = InputBox.Input(窗口标题, 提示文本, 默认返回值, true);
            textBox1.Text = InputBox.Input("输入","请输入","123");
        }
    }
}
