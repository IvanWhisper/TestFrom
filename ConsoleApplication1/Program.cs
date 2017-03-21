using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://10.20.23.199:8081/api/Products");
            var request = new RestRequest(Method.GET);
            RestResponse response = (RestResponse)client.Execute(request);
            var content = response.Content; // raw content as string
            Console.Write(content);
            Console.ReadLine();
        }
    }
}
