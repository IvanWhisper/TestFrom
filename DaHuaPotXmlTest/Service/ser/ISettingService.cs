using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHuaPotXmlTest.Service.ser
{
    /// <summary>
    /// 获取WebConifg节点
    /// </summary>
    public interface ISettingService
    {
        string GetSetting(string settingName);
    }
}
