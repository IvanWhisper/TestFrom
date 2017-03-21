using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace 虚拟键盘
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

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
             System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\osk.exe");//调出屏幕键盘
            //ScreenKeyboard.ShowScreenKeyboard();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ScreenKeyboard.ShowScreenKeyboard();

        }

        private void textBox_Click(object sender, RoutedEventArgs e)
        {

        }

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOREDRAW = 0x0008;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_SHOWWINDOW = 0x0040;
        private const uint SWP_HIDEWINDOW = 0x0080;
        private const uint SWP_NOCOPYBITS = 0x0100;
        private const uint SWP_NOOWNERZORDER = 0x0200;
        private const uint SWP_NOSENDCHANGING = 0x0400;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Interop.WindowInteropHelper winHelper = new System.Windows.Interop.WindowInteropHelper(Application.Current.MainWindow);
            IntPtr mainWindowHandle = winHelper.Handle;
            SetWindowPos(Process.Start(@"C:\WINDOWS\system32\osk.exe").MainWindowHandle,
                mainWindowHandle,
                0,
                0,
                1000,
                500,
                SWP_NOACTIVATE);
        }
    }
}
