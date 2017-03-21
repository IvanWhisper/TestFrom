using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone克隆
{
    class Program
    {
        static void Main(string[] args)
        {
            test a = new test();
            a.a = 1;
            a.b = "2";
            test b = new test();
            b = a;
            b.b ="22";
            b.a = 11;
            Console.WriteLine(a.a);
            Console.WriteLine(a.b);
            Console.WriteLine(b.a);
            Console.WriteLine(b.b);
            Console.WriteLine("*************");

            test c = new test();
            c.a = 3;
            c.b = "4";
            c.c = "5";
            test d = new test();
            d =(test)c.Clone();
            d.b = "44";
            d.a = 33;

            Console.WriteLine(c.a);
            Console.WriteLine(c.b);
            Console.WriteLine(d.a);
            Console.WriteLine(d.b);
            Console.WriteLine(c.c);
            Console.WriteLine(c.c);



            Console.ReadKey();

        }

    }
    class test : ICloneable
    {
        public int a { get; set; }
        public string b { get; set; }
        public string c { get; set; }

        public object Clone()
        {
            return  MemberwiseClone();
        }
    }
}
