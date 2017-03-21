using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 8083;
            string host = "127.0.0.1";

            ///创建终结点（EndPoint）
            IPAddress ip = IPAddress.Parse(host);//把ip地址字符串转换为IPAddress类型的实例
            IPEndPoint ipe = new IPEndPoint(ip, port);//用指定的端口和ip初始化IPEndPoint类的新实例

            Socket sktltn = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sktltn.Bind(ipe);
            sktltn.Listen(30);
            while (true)
            {
                Socket sk = sktltn.Accept();
                ThreadPool.QueueUserWorkItem(p =>
                {
                    Socket skc = (Socket)sk;
                    byte[] array = new byte[10240];
                    int offset = 0;
                    while (true)
                    {
                        int len = skc.Receive(array, offset, array.Length - offset, SocketFlags.None);
                        if (len == 0)
                        {
                            break;
                        }
                        offset += len;

                        string sendStr = "0";
                        byte[] bs = Encoding.ASCII.GetBytes(sendStr);
                        sk.Send(bs, bs.Length, 0);//返回信息给客户端

                    }
                    string content = Encoding.UTF8.GetString(array, 0, offset);
                    Console.WriteLine("> " + content);

                    //sk.Close();
                    //sktltn.Close();
                    //Console.ReadLine();



                }, sk);
            }
        }
    }
}
