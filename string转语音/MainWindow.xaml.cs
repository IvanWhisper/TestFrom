using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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

namespace string转语音
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private SpeechSynthesizer ss;//内容语音值
        public MainWindow()
        {
            InitializeComponent();
            ss = new SpeechSynthesizer();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            sound.instance.soundspeek("123");

            //ss.Rate = -1;//语速条
            //ss.Volume = 100;//音量
            //ss.SpeakAsync(textBox.Text);

        }
    }
}
