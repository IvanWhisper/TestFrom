using DaHuaPotXmlTest.other;
using DaHuaPotXmlTest.Res;
using Microsoft.Practices.Unity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHuaPotXmlTest.Service.ser
{
    [Dependency(typeof(IBarCodeItcAllService))]
    public class BarCodeItcAllService:IBarCodeItcAllService
    {
        private readonly RestClient _client;
        public BarCodeItcAllService(RestClient client)
        {
            _client = client;
        }
       public async Task<BarCodeItcAllRepsentation> ExecuteUpdate(string xmlStr)
        {
            var request = new RestRequest();
            request.RequestFormat = RestSharp.DataFormat.Xml;
            request.AddParameter("text/xml", xmlStr, ParameterType.RequestBody);
            var result = await _client.ExecutePostTaskAsync(request);
            if (result.StatusCode != System.Net.HttpStatusCode.OK) return null;
            var model = XmlHelper.XmlDeserialize<BarCodeItcAllRepsentation>(result.Content, System.Text.Encoding.UTF8);
            return model;
        }

    }
}
