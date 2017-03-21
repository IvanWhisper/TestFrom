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
using System.Drawing;
//using System.Drawing.Drawing2D;
using System.Windows.Shapes;
using System.Drawing.Drawing2D;

namespace Bitmap图片测试
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

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);

        private Bitmap Resize(Bitmap bmp)
        {
            try
            {
                int newWidth = bmp.Width / 4;
                int newHeight = bmp.Height / 4;

                Bitmap b = new Bitmap(newWidth, newHeight);
                Graphics g = Graphics.FromImage(b);

                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, new System.Drawing.Rectangle(0, 0, newWidth, newHeight), new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();
                return b;
            }
            catch (Exception e)
            {
                //log.Error(e);
                return null;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string path = @".\hello";

            Bitmap bitmap = (Bitmap)Bitmap.FromFile(path);
            Bitmap bit = Resize(bitmap);
            if (bit == null)
                return;
            IntPtr ptr = bit.GetHbitmap();
            this.image.Source = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ptr, IntPtr.Zero,
                Int32Rect.Empty, System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            DeleteObject(ptr);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.image.Source = null;
        }
    }
}
