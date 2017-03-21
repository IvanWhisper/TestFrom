using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 设置本地系统时间
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //设置系统当前日期时间
            if (MessageBox.Show("您真的确定更改系统当前日期和时间吗？", "信息提示", MessageBoxButtons.OK) == DialogResult.OK)
            {
                DateTime Year = this.dateTimePicker1.Value;
                SystemTime MySystemTime = new SystemTime();
                SetSystemDateTime.GetLocalTime(MySystemTime);
                MySystemTime.vYear = (ushort)this.dateTimePicker1.Value.Year;
                MySystemTime.vMonth = (ushort)this.dateTimePicker1.Value.Month;
                MySystemTime.vDay = (ushort)this.dateTimePicker1.Value.Day;
                MySystemTime.vHour = 0;// (ushort)this.dateTimePicker1.Value.Hour;
                MySystemTime.vMinute = 0;// (ushort)this.dateTimePicker1.Value.Minute;
                MySystemTime.vSecond = 0;// (ushort)this.dateTimePicker1.Value.Second;
                SetSystemDateTime.SetLocalTime(MySystemTime);
            }
        }
    }
}
