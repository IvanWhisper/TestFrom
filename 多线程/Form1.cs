using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 多线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool CompareVersion(string findVersion, string nowVersion)
        {
            bool result = false;
            string[] findStr = findVersion.Split('.');
            string[] nowStr = nowVersion.Split('.');
            for (int i = 0; i < nowStr.Length; i++)
            {
                if (Convert.ToInt32(findStr[i]) == Convert.ToInt32(nowStr[i]))
                {
                    if (i == nowStr.Length - 1)
                    {
                        result = false;
                    }
                }
                else
                {
                    if (Convert.ToInt32(findStr[i]) > Convert.ToInt32(nowStr[i]))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                    break;
                }
            }
            return result;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string strSN = "12345623";
            int i = Convert.ToInt32(strSN.Substring(strSN.Length - 2));
            int j = i % 60;
            int k = j * 60 * 1000;
            label1.Text = i.ToString();
            label2.Text = j.ToString();

            label3.Text = k.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sv.s.ToString());
            new Form2().Show();
            //this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sv.s.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(CompareVersion(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("更新");
            }
        }
    }
}
