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

namespace XML转化
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string s = @"E:\aaa.txt";
            LOC_UploadDataReprensentation a= XmlHelper.XmlDeserializeFromFile<LOC_UploadDataReprensentation>(s, System.Text.Encoding.UTF8);
            MessageBox.Show(a.xmlns);

        }
    }
}
