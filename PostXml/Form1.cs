using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using SettingsForm;

namespace PostXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //http://192.168.1.147:7001/wsp/gpylpj.jsp
            //http://192.168.1.148:9900/ws/ws.jsp
            string url = "http://192.168.1.147:7001/wsp/gpylpj.jsp";
            XmlDocument xml = new XmlDocument();
            xml.Load(@".\config.ini");
            string strxml = xml.InnerXml;
            label1.Text = strxml;
            string rst=PostXml(url, strxml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(rst);
            string a = doc.SelectNodes("//d")[1].InnerText;
            for(int i=0;i< doc.SelectNodes("//d").Count; i++)
            {
                listBox1.Items.Add(doc.SelectNodes("//d")[i].InnerText);
            }
            textBox1.Text = a;
            MessageBox.Show(a);
        }
        private string PostXml(string url, string strPost)
        {
            //Our postvars  
            //ASCIIEncoding.ASCII.GetBytes（string str）  
            //就是把字符串str按照简体中文(ASCIIEncoding.ASCII)的编码方式，  
            //编码成 Bytes类型的字节流数组;  
            // 要注意的这是这个编码方式，还有内容的Xml内容的编码方式,如果没有注意对应会出现文末的错误  
            byte[] buffer = Encoding.UTF8.GetBytes(strPost);
            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            objRequest.Method = "POST";
            objRequest.ContentLength = buffer.Length;
            objRequest.ContentType = "text/xml";//提交xml   
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(strPost);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                myWriter.Close();
            }
            //读取服务器返回信息  
            //Get the response handle, we have no true response yet!  
            //本文URL：http://www.bianceng.cn/Programming/csharp/201410/45576.htm
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            //using作为语句，用于定义一个范围，在此范围的末尾将释放对象  
            Stream myResponseStream = objResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "LOAD DATA LOCAL INFILE  '" +Environment.CurrentDirectory.Replace("\\","\\\\") + @"\\CompanyData\\comp.csv" + "' replace into table company character set utf8 fields terminated by ',' enclosed by '\"' lines terminated by '\\n' (FCompanyCode, FCompanyName,FCompanyRight,FType)";
                textBox2.Text = str;
            label2.Text = UseConfiguration.getSetting("adc");
         string[] filenames = Directory.GetFiles(@".\");
            MessageBox.Show(System.IO.Path.GetFileName(filenames[0]) + filenames[1]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ag = new string[1];
            ag[0] = "1234";
            Process.Start("text001.exe","123");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url="http://192.168.1.147:7001/wsp/gpylpj.jsp";
            XmlDocument xml = new XmlDocument();
            xml.Load(@".\comconfig.ini");
            string strxml = xml.InnerXml;
            label1.Text = strxml;
            string rst = PostXml(url, strxml);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(rst);

            string aa=doc.DocumentElement.Attributes["st"].Value;
            MessageBox.Show(aa);

           string a = doc.SelectNodes("//d")[0].InnerText;
            for (int i = 0; i < doc.SelectNodes("//d").Count; i++)
            {
                listBox1.Items.Add(doc.SelectNodes("//d")[i].InnerText);
            }
            textBox1.Text = a;
            MessageBox.Show(a);
            WebDownload.DownLoad(a, "data.zip");


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!UseConfiguration.addSetting("adc", textBox3.Text))
            {
                UseConfiguration.updateSeeting("adc", textBox3.Text);
            }
            label2.Text = UseConfiguration.getSetting("adc");
        }
    }
}
