using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 虚拟键盘
{
public class ScreenKeyboard
    {
        /*
        该参数可以是下列值的组合：
        SWP_ASNCWINDOWPOS：如果调用进程不拥有窗口，系统会向拥有窗口的线程发出需求。这就防止调用线程在其他线程处理需求的时候发生死锁。
        SWP_DEFERERASE：防止产生WM_SYNCPAINT消息。
        SWP_DRAWFRAME：在窗口周围画一个边框（定义在窗口类描述中）。
        SWP_FRAMECHANGED：给窗口发送WM_NCCALCSIZE消息，即使窗口尺寸没有改变也会发送该消息。如果未指定这个标志，只有在改变了窗口尺寸时才发送WM_NCCALCSIZE。
        SWP_HIDEWINDOW;隐藏窗口。
        SWP_NOACTIVATE：不激活窗口。如果未设置标志，则窗口被激活，并被设置到其他最高级窗口或非最高级组的顶部（根据参数hWndlnsertAfter设置）。
        SWP_NOCOPYBITS：清除客户区的所有内容。如果未设置该标志，客户区的有效内容被保存并且在窗口尺寸更新和重定位后拷贝回客户区。
        SWP_NOMOVE：维持当前位置（忽略X和Y参数）。
        SWP_NOOWNERZORDER：不改变z序中的所有者窗口的位置。
        SWP_NOREDRAW:不重画改变的内容。如果设置了这个标志，则不发生任何重画动作。适用于客户区和非客户区（包括标题栏和滚动条）和任何由于窗回移动而露出的父窗口的所有部分。如果设置了这个标志，应用程序必须明确地使窗口无效并区重画窗口的任何部分和父窗口需要重画的部分。
        SWP_NOREPOSITION；与SWP_NOOWNERZORDER标志相同。
        SWP_NOSENDCHANGING：防止窗口接收WM_WINDOWPOSCHANGING消息。
        SWP_NOSIZE：维持当前尺寸（忽略cx和Cy参数）。
        SWP_NOZORDER：维持当前Z序（忽略hWndlnsertAfter参数）。
        SWP_SHOWWINDOW：显示窗口。
        返回值 —— 如果函数成功，返回值为非零；如果函数失败，返回值为零。若想获得更多错误消息，请调用GetLastError函数。
        */
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
        [DllImport("user32.dll")]
        /*
        hWnd —— 主窗体窗体句柄
        hWndInsertAfter —— 在z序中位于被置位的窗口前的窗口句柄。
        HWND_BOTTOM：将窗口置于Z序的底部。如果参数hWnd标识了一个顶层窗口，则窗口失去顶级位置，并且被置在其他窗口的底部
        HWND_NOTOPMOST：将窗口置于所有非顶层窗口之上（即在所有顶层窗口之后）。如果窗口已经是非顶层窗口则该标志不起作用
        HWND_TOP:将窗口置于Z序的顶部
        HWND_TOPMOST:将窗口置于所有非顶层窗口之上。即使窗口未被激活窗口也将保持顶级位置
        X —— 以客户坐标指定窗口新位置的左边界。
        Y —— 以客户坐标指定窗口新位置的顶边界。
        cx —— 以像素指定窗口的新的宽度。
        cy —— 以像素指定窗口的新的高度。
        uFlags —— 窗口尺寸和定位的标志。
        */
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X,int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        public static void ShowScreenKeyboard()
        {
            if (System.IO.File.Exists(Environment.SystemDirectory + "\\osk.exe"))
            {
                Process process = new Process();
                //process.StartInfo.UseShellExecute = false;
                //process.StartInfo.RedirectStandardOutput = true;
                //process.StartInfo.RedirectStandardError = true;
                //process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = Environment.SystemDirectory + "\\osk.exe";
                process.StartInfo.Arguments = "";
                process.Start();
                //process.WaitForInputIdle();
                // Process.Start(@"C:\WINDOWS\system32\osk.exe");
                System.Windows.Interop.WindowInteropHelper winHelper = new System.Windows.Interop.WindowInteropHelper(Application.Current.MainWindow);
                IntPtr mainWindowHandle = winHelper.Handle;
                SetWindowPos(process.MainWindowHandle,
                mainWindowHandle,
                0,
                0,
                600,
                200,
                SWP_SHOWWINDOW | SWP_NOZORDER);
                SetForegroundWindow(process.MainWindowHandle);
            }

        }
    }
}
