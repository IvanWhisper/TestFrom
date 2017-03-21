using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF文本输入限制
{
    public class InputCheck
    {
        public static void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Regex rgx = new Regex(@"^(Y|J|(YT\d{0,3})|(JJ\d{0,3}))$");

            //string ss = e.Text;
            //if (!rgx.IsMatch(ss))
            //{
            //    MessageBox.Show("kongge");
            //}
            if (e.Text.Equals(" "))
            {
                MessageBox.Show("13");
            }

        }
    }
}
