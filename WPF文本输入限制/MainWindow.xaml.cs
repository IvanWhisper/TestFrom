using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


namespace WPF文本输入限制
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.MaxLength = 5;
            //textBox.KeyDown += TextBox_KeyDown;
            // textBox.PreviewTextInput +=InputCheck.TextBox_PreviewTextInput;
            //textBox.KeyDown += TextBox_KeyDown1;
            //textBox.KeyDown
            // textBox.PreviewKeyDown += TextBox_PreviewKeyDown;
            //textBox.TextChanged += TextBox_TextChanged;
            textBox.TextChanged += TextBox_TextChanged1;
                }

        private void TextBox_TextChanged1(object sender, TextChangedEventArgs e)
        {
            textBox.MaxLength = 5;

            textBox.Text=textBox.Text.Replace(" ","");
            textBox.Text = textBox.Text.ToUpper();
            textBox.Select(textBox.Text.Length,0);

            bool IsRight=true;
            if (textBox.Text.Length > 0)
            {
                for(int i=0;i<textBox.Text.Length; i++)
                {
                    string a = textBox.Text.Substring(i, 1);
                    switch (i)
                    {
                        case 0:
                            IsRight=(a.Equals("Y") || a.Equals("J")) ? true:false;
                            break;
                        case 1:
                            if (textBox.Text.Substring(i - 1, 1).Equals("Y"))
                            {
                                IsRight = a.Equals("T") ? true : false;
                            }
                            else {
                                IsRight = a.Equals("J") ? true : false;
                            }
                            break;
                        default:
                            Regex rgx = new Regex("^[0-9]");
                            IsRight = rgx.IsMatch(a);
                            break;
                    }
                    if (!IsRight)
                    {
                        MessageBox.Show("123");
                        break;
                    }
                }
            }



        }

        private void TextBox_KeyDown1(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //throw new NotImplementedException();
  

        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
            //e.key

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "我是。。。";
        }
    }
}
/*
1）上一站 输入数字  屏蔽输入法放到XAML InputMethod.IsInputMethodEnabled="False"
2）
*/
