using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity框架.Models
{
    class acClass
    {
    }
    /// <summary>
    /// 计科班
    /// </summary>
    public class CbClass : IClass
    {
        public string ClassName { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("计科班：{0}", ClassName);
        }
    }
    /// <summary>
    /// 电商班
    /// </summary>
    public class EcClass : IClass
    {
        public string ClassName { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("电商班：{0}", ClassName);
        }
    }
}
