using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 测试active
{
    public  class URIcon
    {
        #region Hosts
        public static string CAS_HOST;
        public static string CAS_PORT;
        public static string VPN_HOST;
        public static string VPN_PORT;
        public static string SOA_HOST;
        public static string SOA_PORT;
        public static string AUTH_HOST;
        public static string AUTH_PORT;
        public static string EPN_HOST;
        public static string EPN_PORT;
        #endregion
        #region UriPath
        public static string CAS_LOGIN;
        public static string CAS_LOGOUT;
        public static string CAS_SGLOG;

        public static string EPN_LOGERR;
        public static string EPN_LOGIN;
        public static string EPN_LOGOP;
        public static string EPN_MAC;
        public static string EPN_APP;

        public static string VPN_LOGIN;
        public static string SOA_FNDPW;
        public static string AUTH_AUTH;
        #endregion
        /// <summary>
        /// 从ini当前路径文件中取值，并装载变量
        /// </summary>
        public static void LoadConfig()
        {
            INIClass ic = new INIClass(System.AppDomain.CurrentDomain.BaseDirectory + "uri.ini");
            #region 赋值方法
            CAS_HOST = ic.IniReadValue("Hosts", "CAS_HOST");
            CAS_PORT= ic.IniReadValue("Hosts", "CAS_PORT");
            VPN_HOST = ic.IniReadValue("Hosts", "VPN_HOST");
            VPN_PORT = ic.IniReadValue("Hosts", "VPN_PORT");
            SOA_HOST = ic.IniReadValue("Hosts", "SOA_HOST");
            SOA_PORT = ic.IniReadValue("Hosts", "SOA_PORT");
            AUTH_HOST = ic.IniReadValue("Hosts", "AUTH_HOST");
            AUTH_PORT = ic.IniReadValue("Hosts", "AUTH_PORT");
            EPN_HOST = ic.IniReadValue("Hosts", "EPN_HOST");
            EPN_HOST = ic.IniReadValue("Hosts", "EPN_HOST");

            CAS_LOGIN = ic.IniReadValue("UriPath", "CAS_LOGIN");
            CAS_LOGOUT = ic.IniReadValue("UriPath", "CAS_LOGOUT");
            CAS_SGLOG = ic.IniReadValue("UriPath", "CAS_SGLOG");

            EPN_LOGERR = ic.IniReadValue("UriPath", "EPN_LOGERR");
            EPN_LOGIN = ic.IniReadValue("UriPath", "EPN_LOGIN");
            EPN_LOGOP = ic.IniReadValue("UriPath", "EPN_LOGOP");
            EPN_MAC = ic.IniReadValue("UriPath", "EPN_MAC");
            EPN_APP = ic.IniReadValue("UriPath", "EPN_APP");

            VPN_LOGIN = ic.IniReadValue("UriPath", "VPN_LOGIN");
            SOA_FNDPW = ic.IniReadValue("UriPath", "SOA_FNDPW");
            AUTH_AUTH = ic.IniReadValue("UriPath", "AUTH_AUTH");
            #endregion
        }
        /// <summary>
        /// URI拼接
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="uripath"></param>
        /// <returns></returns>
        /* 使用范本，最好后期能将参数的类型再次进行分类
            URIcon.URIConfig(URIcon.CAS_HOST, URIcon.CAS_PORT, URIcon.CAS_LOGIN)
            URIcon.URIConfig(URIcon.CAS_HOST, URIcon.CAS_PORT, URIcon.CAS_LOGOUT)
            URIcon.URIConfig(URIcon.CAS_HOST, URIcon.CAS_PORT, URIcon.CAS_SGLOG)
            URIcon.URIConfig(URIcon.AUTH_HOST, URIcon.AUTH_PORT, URIcon.AUTH_AUTH)
            URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_APP)
            URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_LOGERR)
            URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_LOGIN)
            URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_LOGOP)
            URIcon.URIConfig(URIcon.EPN_HOST, URIcon.EPN_PORT, URIcon.EPN_MAC)
            URIcon.URIConfig(URIcon.SOA_HOST, URIcon.SOA_PORT, URIcon.SOA_FNDPW)
            URIcon.URIConfig(URIcon.SOA_HOST, URIcon.SOA_PORT, URIcon.SOA_FNDPW)
            URIcon.URIConfig(URIcon.VPN_HOST, URIcon.VPN_PORT, URIcon.VPN_LOGIN)
        */
        public static string URIConfig(string host,string port,string uripath)
        {
            return host + ":" + port + "/" + uripath;
        }
    
    }
 }
