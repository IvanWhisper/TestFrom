﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 获取本地磁盘信息
{
    class cmdhelper
    {
        private static string CmdPath = @"C:\Windows\System32\cmd.exe";

        /// <summary>  
        /// 执行cmd命令  
        /// 多命令请使用批处理命令连接符：  
        /// <![CDATA[  
        /// &:同时执行两个命令  
        /// |:将上一个命令的输出,作为下一个命令的输入  
        /// &&：当&&前的命令成功时,才执行&&后的命令  
        /// ||：当||前的命令失败时,才执行||后的命令]]>  
        /// </summary>  
        /// <param name="cmd"></param>  
        /// <param name="output"></param>  
        public static void RunCmd(string cmd)
        {
            try
            {
                //cmd = cmd.Trim().TrimEnd('&') + "&exit";//说明：不管命令是否成功均执行exit命令，否则当调用ReadToEnd()方法时，会处于假死状态  
                cmd = cmd.Trim();
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = CmdPath;
                    p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动  
                    p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息  
                    p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息  
                    p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出  
                    p.StartInfo.CreateNoWindow = true;          //不显示程序窗口  
                    p.Start();//启动程序  

                    //向cmd窗口写入命令  
                    string s = cmd[0].ToString() + ":";
                    p.StandardInput.WriteLine(s);
                    p.StandardInput.WriteLine("cd " + cmd);

                    Thread.Sleep(1000);

                    p.StandardInput.AutoFlush = true;
                    DriveInfo dinfo = new DriveInfo(cmd);

                    //MessageBox.Show(cmd);
                    //string abc = "onclick=\"start()\"";
                    //20161209 叶基炳  防止时间久了硬盘爆
                    for (int i=30;i>0;i--)
                    {
                        if ((Convert.ToDouble(dinfo.AvailableFreeSpace) / Convert.ToDouble(dinfo.TotalSize)) > 0.806)
                        {
                            break;
                        }
                        string m = string.Format($"forfiles /p . /d -{i} /s /m * /c \"cmd /c del /f @path\"");
                        //string m = string.Format($"forfiles /p {cmd} /d -{GlobalInfo.PicLiveTime} /s /m *.* /c \"cmd /c del /f @path\"");
                        //MessageBox.Show(m);
                        Thread.Sleep(1000);
                        p.StandardInput.WriteLine(m);
                    }

                    //获取cmd窗口的输出信息  
                    //output = p.StandardOutput.ReadToEnd();
                    //p.WaitForExit();//等待程序执行完退出进程  
                    p.Close();
                }

            }
            catch (Exception ex)
            {
            }
        }

    }
}
