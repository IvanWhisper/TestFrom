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
using WebSocket4Net;


namespace WebSocketClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private WebSocket websocket = null;
        private string strSendText = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
            websocket = new WebSocket("ws://127.0.0.1:7181");
            websocket.Opened += websocket_Opened;
            websocket.Closed += websocket_Closed;
            websocket.MessageReceived += websocket_MessageReceived;
            websocket.Open();
        }
        private void websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            //this.listBox1.Invoke(new EventHandler(ShowMessage), e.Message);
            MessageReceivedEventArgs responseMsg = (MessageReceivedEventArgs)e; //接收服务端发来的消息
            string strMsg = responseMsg.Message;
        }

        private void ShowMessage(object sender, EventArgs e)
        {
           // this.listBox1.Items.Add(sender.ToString());
        }
        private void websocket_Closed(object sender, EventArgs e)
        {
            websocket.Send("一个客户端 下线");
        }

        void websocket_Opened(object sender, EventArgs e)
        {
            websocket.Send("一个客户端 上线");
        }

    }
}
