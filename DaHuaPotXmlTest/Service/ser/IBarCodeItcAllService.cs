using DaHuaPotXmlTest.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHuaPotXmlTest.Service.ser
{
    public interface IBarCodeItcAllService
    {
        Task<BarCodeItcAllRepsentation> ExecuteUpdate(string xmlStr);
    }
}
