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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int i=0;
        int j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text.Substring(2,3));
            timer1.Enabled = !timer1.Enabled;
            timer2.Enabled = !timer2.Enabled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public async Task adc()
        {
            i += timer1.Interval;
            listBox1.Items.Add( i.ToString());
        }
        public async Task dc()
        {
            while (staticVar.OF) {
               // Sleep(100);
                double i = 0;
                DateTime dt = DateTime.Now;
                TimeSpan ts = dt - staticVar.timePrev;
                i = ts.TotalSeconds;
                staticVar.ot = (i > 30 ? i : 0);
                staticVar.timePrev = dt;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            j += timer1.Interval;
            listBox1.Items.Add(j.ToString());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            adc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staticVar.OF = true;
            staticVar.timeStart = DateTime.Now;
            staticVar.timePrev = staticVar.timeStart;

            //dc().Start();
            //dc().
            new Form2().Show();
            //this.Close();
        }
    }
}
