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
using System.Windows.Shapes;

namespace InputBoxDemoWPF
{
    /// <summary>
    /// InputBox.xaml 的交互逻辑
    /// </summary>
    public partial class InputBox : Window
    {
        public InputBox()
        {
            InitializeComponent();

            btn_submit.Click += buttonOK_Click;
        }
        private void Init()
        {
        }

        public static string Input(string Title, string Text, string DefaultValue)
        {
            InputBox inputBox = new InputBox();
            inputBox.Title= Title;
            inputBox.txb_input.Text = Text;
            //DialogResult result = inputBox.ShowDialog();
            if (inputBox.ShowDialog() == true)
            {
                return inputBox.txt_input.Text;
            }
            else
            {
                return DefaultValue;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult =true;
        }
    }
}
