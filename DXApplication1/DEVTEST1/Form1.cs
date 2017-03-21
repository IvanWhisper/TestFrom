using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MessageFormBuild;
using CCWin;

namespace DEVTEST1
{
    public partial class Form1 : SkinMain
    {
        TabControlBuild tb;
        public Form1()
        {
            InitializeComponent();
            xtraTabControl1.Selected += XtraTabControl1_Selected;
            xtraTabControl1.SelectedPageChanged += XtraTabControl1_SelectedPageChanged;
        }

        private void XtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            //throw new NotImplementedException();
            tb.TabPageChange(GetDT());
        }

        private void XtraTabControl1_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            //throw new NotImplementedException();
           // tb.TabPageChange(GetDT());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb = new TabControlBuild(xtraTabControl1);
            tb.BuildingTabControl(GetDT());
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
        public DataTable GetDT()
        {
            //数据库取表
            string con = "Data Source=.;Initial Catalog=abc;Persist Security Info=True;User ID=sa;Password=123456";
            string sqlstr = "select msgst,sysid,mesage,msgdate from mesage";
            SqlConnection cn = new SqlConnection(con);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataAdapter ap = new SqlDataAdapter(sqlstr, cn);
            ap.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable GetDT(DataTable dt)
        {
            DataTable dtt = dt.DefaultView.ToTable(false, new string[] {"state","send_system","title","send_time"});
            return dtt;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
