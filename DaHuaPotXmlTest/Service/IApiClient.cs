using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaHuaPotXmlTest.Models;
using DaHuaPotXmlTest.Res;
using DaHuaPotXmlTest.Service.ser;

namespace DaHuaPotXmlTest.Service
{
    public interface IApiClient
    {
        IBarCodeItcAllService barCodeItcAllService { get; }
    }
}
