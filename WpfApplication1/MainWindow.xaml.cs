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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += sj;
            button1.Click += sj;
            button2.Click += sj;
            button3.Click += sj;
            textBox.TextChanged += sj;

        }
        public void sj(object sender,RoutedEventArgs e)
        {
            MessageBox.Show("123");
            abc((Button)sender);
        }
        public void abc(Button bt)
        {
            bt.Content = "123";

        }
    }
}

