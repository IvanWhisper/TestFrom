using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace WPFBinding测试
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        // TempDataTable tempData;
        DataTable dt;
        public MainWindow()
        {
            InitializeComponent();
            //tempData = new TempDataTable();
            dt = new DataTable();
            dt.Columns.Add("DOC_ID", typeof(string));
            dt.Columns.Add("OBJ_WEI", typeof(string));
            dt.Columns.Add("FStatus", typeof(Int32));
            dt.Columns.Add("SCAN_TIME", typeof(DateTime));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            DataRow dr =dt.NewRow();
            dr["DOC_ID"] = "a1";
            dr["OBJ_WEI"] = "a2";
            dr["FStatus"] = 3;
            dr["SCAN_TIME"] = DateTime.Now;
            dt.Rows.Add(dr);

            //List<string> paramList = new List<string>();
            //paramList.Add("1");
            //paramList.Add("3");
            //paramList.Add("0");
            //paramList.Add(DateTime.Now.ToString());

            //tempData.AddRowData(paramList);

            dg_logs.ItemsSource = null;
            dg_logs.ItemsSource =dt.DefaultView;
            // dg_logs.DataContext = tempData.tempDT;

           
            var rows = dt.AsEnumerable()
                    .Where(p => p.Field<string>("DOC_ID") == " " && p.Field<string>("SCAN_TYPE") == "asd")
                    .Select(p => new
                    {
                        FStatus = p.Field<string>("FStatus"),
                        DB_Time = p.Field<decimal>("DB_Time")
                    });
            rows.ToList();

        }
    }
}
