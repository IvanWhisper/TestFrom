using DaHuaPotXmlTest.Service.ser;
using Microsoft.Practices.Unity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DaHuaPotXmlTest.Service
{
    public class ApiClient:IApiClient
    {
        private readonly RestClient client;
        public ApiClient(ISettingService settingService)
        {
            try
            {
                string apiHost = settingService.GetSetting(SettingNames.ApiEndpointHost);
                this.client = new RestClient(apiHost);
                this.client.AddDefaultHeader("Content-Type", "text/xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("请检查上传服务器地址格式的配置是否正确\n " + ex.ToString());
            }
        }
        public IBarCodeItcAllService barCodeItcAllService => new BarCodeItcAllService(client);
    }
}
