
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 图片压缩
{
    class Program
    {
        static void Main(string[] args)
        {
            long sta = System.Environment.TickCount;
            PicResize.GetPicThumbnail(@".\pic\1", @".\pic\a", 50);
            //PicResize.GetPicThumbnail(@".\pic\1", @".\pic\a",2000,3000, 50);
            //PicResize.GetPicThumbnail(System.AppDomain.CurrentDomain.BaseDirectory+@"pic\1", System.AppDomain.CurrentDomain.BaseDirectory + @"pic\a", 50);
            long ena = System.Environment.TickCount-sta;


            Console.Write(ena);
            Console.ReadKey();

        }
    }
}
