using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 测试active
{
    public partial class Form1 : Form
    {
        INIClass ic;
        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += Form1_SizeChanged;
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (this.WindowState == FormWindowState.Maximized)//捕获窗体最大化事件  
            {
                label2.Text = "窗体最大化";
            }
            if (this.WindowState == FormWindowState.Normal)//捕获还原（Normal)事件  
            {
                label2.Text = "窗体还原";

            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                label1.Text = "当前隐藏";
                label3.Text = "隐藏过";
            }
            // throw new NotImplementedException();
            label1.Text = "当前不活动";

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            label1.Text = "当前活动";

            //throw new NotImplementedException();
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("123");
            //throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fip = System.AppDomain.CurrentDomain.BaseDirectory + "uri.ini";
           ic = new INIClass(fip);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = URIcon.CAS_HOST;
            URIcon.LoadConfig();
            label5.Text = URIcon.URIConfig(URIcon.CAS_HOST, URIcon.CAS_PORT, URIcon.CAS_LOGIN);
            listBox1.Items.Clear();
            listBox1.Items.Add(URIcon.URIConfig(URIcon.CAS_HOST, URIcon.CAS_PORT, URIcon.CAS_LOGIN));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.CAS_HOST, URIcon.CAS_PORT, URIcon.CAS_LOGOUT));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.CAS_HOST, URIcon.CAS_PORT, URIcon.CAS_SGLOG));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.AUTH_HOST, URIcon.AUTH_PORT, URIcon.AUTH_AUTH));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_APP));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_LOGERR));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_LOGIN));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_LOGOP));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_MAC));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.SOA_HOST, URIcon.SOA_PORT, URIcon.SOA_FNDPW));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.SOA_HOST, URIcon.SOA_PORT, URIcon.SOA_FNDPW));
            listBox1.Items.Add(URIcon.URIConfig(URIcon.VPN_HOST, URIcon.VPN_PORT, URIcon.VPN_LOGIN));



        }
    }
}
