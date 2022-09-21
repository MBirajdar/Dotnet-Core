using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DAy1
{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Program p = new Program();
//            int res = p.add(5, 6); //calling function
//            Console.WriteLine(res);
//            Console.ReadLine();


//            Console.WriteLine("enter name");
//            string name = Console.ReadLine();
//            Console.WriteLine("Hello {0} Welcome to CSharp", name);
//            Console.WriteLine("Hello" + " " + name + " "+ "Welcome to CSharp");
//            Console.WriteLine($"Hello {name} {name} welcome to CSharp");
//            Console.ReadLine();
//        }
//         public int add(int a, int b) // called function
//        {
//            return a + b;
//        }
//    }

    class Program
    {
        public enum DayofWeek
        {
            Sunday =  2,Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Sunday, DayofWeek.Sunday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Monday, DayofWeek.Monday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Tuesday, DayofWeek.Tuesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Wednesday, DayofWeek.Wednesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Thursday, DayofWeek.Thursday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Friday, DayofWeek.Friday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Saturday, DayofWeek.Saturday);
            Console.ReadLine();
        }
    }
}
