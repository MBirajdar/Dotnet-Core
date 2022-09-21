using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
namespace ConsoleProject
{
    class Program
    { 
        //linq to entity
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Manoj", "Ram", "Shivam", "Rahul", "Kishor", "Suresh" };

            //usng LINQ queries   (extenstion methods)
            // UsingLinq(names);  1st type 
            // UsingLINQExtensions(names); 2nd type or style
            // UsingLINQFunctions(names); 3rd type
            UsingAnonmysMethods(names);
        }
        //private static void UsingLinq(string[] names)
        //{
        //    IEnumerable<String> query = from s in names
        //                                where s.Length == 5
        //                                orderby s
        //                                select s.ToUpper();
        //    //select * from names where 
        //    foreach (string item in query)
        //        Console.WriteLine(item);
        //    Console.ReadLine();

        //}
        //private static void UsingLINQExtensions(string[] names)    //Lamba expression
        //{
        //    IEnumerable<String> query = names
        //                                .Where(s=> s.Length == 5)
        //                                .OrderBy(s=>s)
        //                                .Select (s=>s.ToUpper());
        //    foreach (string item in query)
        //        Console.WriteLine(item);
        //    Console.ReadLine();

        //}
        //private static void UsingLINQFunctions(string[] names)    
        //{
        //    Func<string, bool> filter = s => s.Length == 5;
        //    Func<string, string> extract = (s => s);
        //    Func<string, string> project = s => s.ToUpper();

        //    IEnumerable<String> query = names
        //                                .Where(filter)
        //                                .OrderBy(extract)
        //                                .Select(project);
        //    foreach (string item in query)
        //        Console.WriteLine(item);
        //    Console.ReadLine();

        //}
        private static void UsingAnonmysMethods(string[] names)
        {
            Func<string, bool> filter = delegate (string s)
            {
                return s.Length == 5;
            };
            Func<string, string> extract = delegate (string s)
            {
                return s;
            }; Func<string, string> project = delegate (string s)
            {
                return s.ToUpper();
            };
           

            IEnumerable<String> query = names
                                        .Where(filter)
                                        .OrderBy(extract)
                                        .Select(project);
            foreach (string item in query)
                Console.WriteLine(item);
            Console.ReadLine();

        }
    }
}
