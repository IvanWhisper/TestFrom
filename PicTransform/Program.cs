using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            //图片转二进制  
            byte[] imageByte = PictureTransf.GetPictureData(@"E:\Penguins.jpg");
            //二进制转换成字符串  
            string picStr = Convert.ToBase64String(imageByte);
            //输出字符串  
            Console.Write(picStr);

            //字符串转二进制  
            byte[] imageBytes = Convert.FromBase64String(picStr);
            //读入MemoryStream对象  
            MemoryStream memoryStream = new MemoryStream(imageBytes, 0, imageBytes.Length);
            memoryStream.Write(imageBytes, 0, imageBytes.Length);
            //二进制转成图片保存  
            System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream);
            image.Save(@"D:\P.jpg");

            Console.ReadKey();
        }
    }
}
