using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity框架研究2017
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string value)
        {
            Console.WriteLine(string.Format("ConsoleLogger:{0}", value));
        }
    }
    public class NullLogger : ILogger
    {
        public void Log(string value)
        {
            Console.WriteLine("NullLogger:Hey,Nothing to  do!");
        }
    }
}
