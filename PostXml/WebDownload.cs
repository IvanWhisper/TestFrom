using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostXml
{
    public class WebDownload
    {
        public static void DownLoad(string Url, string FileName)
        {
            bool Value = false;
            WebResponse response = null;
            Stream stream = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);

                //NetworkCredential netCred = new NetworkCredential();
                //netCred.Domain = string.Empty;
                //netCred.UserName = string.Empty;
                //netCred.Password = string.Empty;

                //request.Credentials = netCred;

                response = request.GetResponse();
                stream = response.GetResponseStream();

                if (!response.ContentType.ToLower().StartsWith("text/"))
                {
                    Value = SaveBinaryFile(response, FileName);

                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
                Environment.Exit(-1);
            }

        }

        /// <summary>
        /// Save a binary file to disk.
        /// </summary>
        /// <param name="response">The response used to save the file</param>
        // 将二进制文件保存到磁盘
        private static bool SaveBinaryFile(WebResponse response, string FileName)
        {
            bool Value = true;
            byte[] buffer = new byte[1024];

            try
            {
                if (File.Exists(FileName))
                    File.Delete(FileName);
                Stream outStream = System.IO.File.Create(FileName);
                Stream inStream = response.GetResponseStream();

                int l;
                do
                {
                    l = inStream.Read(buffer, 0, buffer.Length);
                    if (l > 0)
                        outStream.Write(buffer, 0, l);
                }
                while (l > 0);

                outStream.Close();
                inStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Value = false;
            }
            return Value;
        }
    }
}
