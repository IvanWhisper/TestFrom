using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using System.Reflection;

namespace 程序日志的使用
{
    public partial class Form1 : Form
    {
        ILog loginfo = log4net.LogManager.GetLogger("loginfo");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginfo.Info("info");
            loginfo.Warn("warn");
            loginfo.Error("error");
            loginfo.Debug("debug");
       }
    }
}
