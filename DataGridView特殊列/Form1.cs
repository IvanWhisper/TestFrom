using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_SQLHelper;

namespace DataGridView特殊列
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDt();
            DataGridViewButtonColumn Column1 = new DataGridViewButtonColumn();
            Column1.DefaultCellStyle.NullValue= "查看";
            Column1.HeaderText = "item";
            this.dataGridView1.Columns.Add(Column1);
        }
        public DataTable GetDt()
        {
            DataTable dt = new DataTable();
            string con = "Data Source=.;Initial Catalog=TestApi;Persist Security Info=True;User ID=sa;Password=123456";
            string sqlstr = "select * from ProductInfo";
            dt = SqlHelper.ExecuteDataset(con, CommandType.Text, sqlstr).Tables[0];
            return dt;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
       
                dataGridView1.Rows[0].Cells[2].Style.Font = new Font("宋体", 12, FontStyle.Underline);
                dataGridView1.Rows[0].Cells[2].Style.ForeColor = Color.Blue;
                dataGridView1.Rows[0].Cells[2].ToolTipText = string.Format("我是第{0}行，第{1}列的单元格",0, e.ColumnIndex);

        }
    }
}
