using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoproject
{
    class ExplicitConDemo
    {
        public ExplicitConDemo()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            ExplicitConDemo obj1 = new ExplicitConDemo();
            ExplicitConDemo obj2 = new ExplicitConDemo();
            Console.ReadLine();
        }
    }
}
