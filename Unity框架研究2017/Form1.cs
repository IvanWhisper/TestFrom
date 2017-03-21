using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unity框架研究2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, ConsoleLogger>();
            ILogger logger = container.Resolve<ILogger>();
            logger.Log("have a look!");
        }
    }
}
