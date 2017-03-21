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

namespace 加载窗体Splash_WPF
{
    /// <summary>
    /// Splash.xaml 的交互逻辑
    /// </summary>
    public partial class Splash : Window
    {
        public Splash()
        {
            InitializeComponent();
        }
        //关闭自身 
        public void KillMe(object o, EventArgs e)
        {
            this.Close();
        }
        /// <summary> 
        /// 加载并显示主窗体 
        /// </summary> 
        /// <param name="window">主窗体</param> 
        public static void LoadAndRun(Window window)
        {
            //订阅主窗体的句柄创建事件 
            window.HandleCreated += delegate
            {
                //启动新线程来显示Splash窗体 
                new Thread(new ThreadStart(delegate
                {
                    Splash splash = new Splash();
                    //订阅主窗体的Shown事件 
                    window.Shown += delegate
                    {
                        //通知Splash窗体关闭自身 
                        splash.Invoke(new EventHandler(splash.KillMe));
                        splash.Dispose();
                    };
                    //显示Splash窗体 
                    Application.Run(splash);
                })).Start();
            };
            //显示主窗体 
            Application.Run(window);
        }

    }
}
