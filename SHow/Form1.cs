using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBTools;


namespace SHow
{
    public partial class Form1 : Form
    {
        string con = "Data Source=.;Initial Catalog=abc;Persist Security Info=True;User ID=sa;Password=123456";
        string sqlstr = "select msgst,sysid,mesage,msgdate from mesage";
        string sqldel = "delte/////";
        DBLINK dk = new DBLINK();
        model1 m1 = new model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            dataGridView1.DataSource =dk.ReturnDT(con,sqlstr) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dk.ReturnDT(con, sqldel);
        }
    }
}
