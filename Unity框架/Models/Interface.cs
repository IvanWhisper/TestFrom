using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity框架.Models
{
    class Interface
    {
    }
    /// <summary>
    /// 班级接口
    /// </summary>
    public interface IClass
    {
        string ClassName { get; set; }

        void ShowInfo();
    }

}
