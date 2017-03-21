using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程序单例运行与重新启动
{
    //使用线程互斥变量. 通过定义互斥变量来判断是否已运行实例. 把program.cs文件里的Main()函数改为如下代码:
    static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool FlashWindow(IntPtr hWnd, bool bInvert);
        [DllImport("user32.dll")]
        private static extern bool FlashWindowEx(int pfwi);
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool runone;
            System.Threading.Mutex run = new System.Threading.Mutex(true, "single_test", out runone);
            if (runone)
            {
                run.ReleaseMutex();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Form1 frm = new Form1();

                int hdc = frm.Handle.ToInt32(); // write to ...

                Application.Run(frm);
                IntPtr a = new IntPtr(hdc);
            }
            else
            {
                MessageBox.Show("已经运行了一个实例了。");
                //IntPtr hdc = new IntPtr(1312810); // read from...
                //bool flash = FlashWindow(hdc, true);
            }
        }
    }
}

