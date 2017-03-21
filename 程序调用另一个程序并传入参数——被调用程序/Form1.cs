using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程序调用另一个程序并传入参数__被调用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Satvar.StcString.Length > 0)
            {
                label1.Text ="第一个参数"+ Satvar.StcString[0];
            }
        }
    }
}
