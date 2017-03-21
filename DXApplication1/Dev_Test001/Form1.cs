using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraTab;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Dev_Test001
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            xtraTabControl1.SelectedPageChanged += XtraTabControl1_SelectedPageChanged;
            xtraTabControl1.Selected += XtraTabControl1_Selected;
        }

        private void XtraTabControl1_Selected(object sender, TabPageEventArgs e)
        {

        }

        private void XtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            //SetTabPage();
            if (xtraTabControl1.TabPages.Count > 0)
            {
                if (xtraTabControl1.SelectedTabPage.Controls.Count > 0) { xtraTabControl1.SelectedTabPage.Controls.Clear(); }
                GetDT();
                DataView view = new DataView();
                view=dt.DefaultView;
                view.RowFilter =string.Format("sysid = '{0}'", xtraTabControl1.SelectedTabPage.Text);
                DataGridView dgv = new DataGridView();
                dgv.DataSource= view.ToTable();

                Label lab = new Label();
                lab.Text = string.Format("  {0}消息", xtraTabControl1.SelectedTabPage.Text);
                lab.AutoSize = false;
                lab.Font = new Font("微软雅黑", 12,FontStyle.Bold);
                lab.TextAlign = ContentAlignment.MiddleLeft;

                TableLayoutPanel tlp = new TableLayoutPanel();
                tlp.RowCount = 2;
                tlp.ColumnCount = 1;
                tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
                tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));

                tlp.Controls.Add(lab,0, 0);
                tlp.Controls.Add(dgv,0,1);
                
                xtraTabControl1.SelectedTabPage.Controls.Add(tlp);

                lab.Dock = DockStyle.Fill;
                setDGV(dgv);
                tlp.Dock = DockStyle.Fill;
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDT();
            SetTabPage();

            
            

            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor =Color.White;
            dataGridView1.ReadOnly=true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }
        public void GetDT()
        {
            //数据库取表
            string con = "Data Source=.;Initial Catalog=abc;Persist Security Info=True;User ID=sa;Password=123456";
            string sqlstr = "select * from mesage";
            SqlConnection cn = new SqlConnection(con);
            dt = new DataTable();
            cn.Open();
            SqlDataAdapter ap = new SqlDataAdapter(sqlstr, cn);
            ap.Fill(dt);
            cn.Close();
        }
        public void SetTabPage()
        {
            List<string> ls = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ls.Add(dt.Rows[i]["sysid"].ToString());
            }
            List<string> lss = ls.Distinct().ToList();

            xtraTabControl1.TabPages.Clear();

            foreach (string nm in lss)
            {
                listBox1.Items.Add(nm);
                XtraTabPage xTabPage = new XtraTabPage();
                xTabPage.Text = nm;
                xtraTabControl1.TabPages.Add(xTabPage);
            }
           
        }
        public void setDGV(DataGridView dgv)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Formtest().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
