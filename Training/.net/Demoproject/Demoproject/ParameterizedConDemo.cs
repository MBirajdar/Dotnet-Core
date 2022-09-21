using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoproject
{
    class ParameterizedConDemo
    {
        public ParameterizedConDemo(int i)
        {
            Console.WriteLine("Parameterized Constructor is called: " + i);
        }
        static void Manin()
        {
            ParameterizedConDemo obj1 = new ParameterizedConDemo(10);
            ParameterizedConDemo obj2 = new ParameterizedConDemo(20);
            Console.ReadLine();

        }
    }
}
