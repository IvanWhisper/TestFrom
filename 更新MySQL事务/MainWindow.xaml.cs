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
using MySql.Data.MySqlClient;

namespace 更新MySQL事务
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<string> CommandTextList = new List<string>();
            CommandTextList.Add("Delete from company");

            string str = "LOAD DATA LOCAL INFILE  '" + Environment.CurrentDirectory.Replace("\\", "\\\\") + @"\\CompanyData\\comp.csv" + "' replace into table company character set utf8 fields terminated by ',' enclosed by '\"' lines terminated by '\\n' (FCompanyCode, FCompanyName,FCompanyRight,FType)";
            //MessageBox.Show(str);
            CommandTextList.Add(str);

            textBox.Text=ExecuteNonQueryWithTrans(CommandTextList);


        }
        public string ExecuteNonQueryWithTrans(List<string> CommandTextList)
        {
            string ResultStr = string.Empty;
            if (CommandTextList.Count > 0)
            {
                string ConnectionStr = System.Configuration.ConfigurationManager.AppSettings["mysqlconn"];
                MySqlConnection mysqlconnection = new MySqlConnection(ConnectionStr);
                mysqlconnection.Open();
                MySqlTransaction mysqltransaction = mysqlconnection.BeginTransaction();
                MySqlCommand mysqlcommand = new MySqlCommand();
                mysqlcommand.Connection = mysqlconnection;
                mysqlcommand.Transaction = mysqltransaction;
                try
                {
                    foreach (string commText in CommandTextList)
                    {
                        mysqlcommand.CommandText = commText;
                        int i=mysqlcommand.ExecuteNonQuery();
                        ResultStr += "#" + i;
                    }
                    mysqltransaction.Commit();
                }
                catch (Exception ex)
                {
                    ResultStr += "#" + ex.ToString();
                    mysqltransaction.Rollback();
                   // log.Error(ex);
                }
                finally
                {
                    mysqlconnection.Close();
                    mysqltransaction.Dispose();
                    mysqlconnection.Dispose();
                }
            }
            return ResultStr;

        }
    }
}
