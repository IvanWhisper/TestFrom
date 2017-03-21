using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 获取本地磁盘信息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text =@"D:\C_Sharp_Pro\MyProject\Reseach\Thunks\IvanPrivateDemo\TestFrom\获取本地磁盘信息\bin\Debug\pic";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo dinfo = new DriveInfo(textBox1.Text);
            listBox1.Items.Add("指示驱动器上的可用空闲空间总量（以字节为单位）");
            //指示驱动器上的可用空闲空间总量（以字节为单位）。
            listBox1.Items.Add(dinfo.AvailableFreeSpace);
            listBox1.Items.Add("获取文件系统的名称，例如 NTFS 或 FAT32");
            //获取文件系统的名称，例如 NTFS 或 FAT32。
            listBox1.Items.Add(dinfo.DriveFormat);
            listBox1.Items.Add("获取驱动器类型，如 CD-ROM、可移动、网络或固定");
            //获取驱动器类型，如 CD-ROM、可移动、网络或固定。
            listBox1.Items.Add(dinfo.DriveType);
            listBox1.Items.Add("获取一个指示驱动器是否已准备好的值");
            //获取一个指示驱动器是否已准备好的值。
            listBox1.Items.Add(dinfo.IsReady);
            listBox1.Items.Add("获取驱动器的名称，如 C:\\");
            //获取驱动器的名称，如 C:\。
            listBox1.Items.Add(dinfo.Name);
            listBox1.Items.Add("获取驱动器的根目录");
            //获取驱动器的根目录。
            listBox1.Items.Add(dinfo.RootDirectory);
            listBox1.Items.Add("获取驱动器上的可用空闲空间总量（以字节为单位）");
            //获取驱动器上的可用空闲空间总量（以字节为单位）。
            listBox1.Items.Add(dinfo.TotalFreeSpace);
            listBox1.Items.Add("获取驱动器上存储空间的总大小（以字节为单位）");
            //获取驱动器上存储空间的总大小（以字节为单位）。
            listBox1.Items.Add(dinfo.TotalSize);
            listBox1.Items.Add("获取或设置驱动器的卷标");
            //获取或设置驱动器的卷标。
            listBox1.Items.Add(dinfo.VolumeLabel);
            //   listBox1.Items.Add(dinfo);
            string mesg = dinfo.Name + "#" + (Convert.ToDouble(dinfo.AvailableFreeSpace) / Convert.ToDouble(dinfo.TotalSize)).ToString("0.0000000");
            listBox1.Items.Add(mesg);


            if((Convert.ToDouble(dinfo.AvailableFreeSpace) / Convert.ToDouble(dinfo.TotalSize)) < 0.78206)
            {
                MessageBox.Show("123");
            }
            FileInfo finfo = new FileInfo("E:\\test\\8");
            listBox2.Items.Add(finfo.CreationTime);
            listBox2.Items.Add(finfo.CreationTimeUtc);
            listBox2.Items.Add(finfo.Name);
            listBox2.Items.Add(finfo.Extension);
            listBox2.Items.Add(finfo.FullName);
            listBox2.Items.Add(finfo.LastAccessTime);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fin = new FileInfo("E:\\test\\9");
            if (fin.Exists)
            {
                fin.Delete();
            }
            else
            {
                MessageBox.Show("null");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmdhelper.RunCmd(System.AppDomain.CurrentDomain.BaseDirectory + "pic\\");
        }
    }
}
