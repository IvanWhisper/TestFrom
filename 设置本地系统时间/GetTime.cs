using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 设置本地系统时间
{
    class GetTime
    {
        #region public static string GetResponse(string url)
        /// <summary>
        /// 获取一个网页
        /// </summary>
        /// <param name="url">地址</param>
        /// <returns>字符串返回值</returns>
        public static string GetResponse(string url)
        {
            string result = null;
            WebResponse webResponse = null;
            StreamReader streamReader = null;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "GET";
                webResponse = httpWebRequest.GetResponse();
                streamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
                result = streamReader.ReadToEnd();
            }
            catch
            {
                // handle error
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                if (webResponse != null)
                {
                    webResponse.Close();
                }
            }
            return result;
        }
        #endregion
    }
}
