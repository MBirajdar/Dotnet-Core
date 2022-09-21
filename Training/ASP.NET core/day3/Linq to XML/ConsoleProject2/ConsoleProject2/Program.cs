using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Manoj", "Ram", "Shivam", "Rahul", "Kishor", "Suresh" };
            // LINQReadXML(names); 
            // LINQReadXMLAddNode(names);  //add
            LINQReadXMLDeleteNode(names);


        }
        //public static void LINQReadXML(string[] names)
        //{
        //    string myXML = @"<Departments>
        //               <Department>Account</Department>
        //               <Department>Sales</Department>
        //               <Department>Pre-Sales</Department>
        //               <Department>Marketing</Department>
        //               </Departments>";


        //    XDocument xdoc = new XDocument();
        //    xdoc = XDocument.Parse(myXML);
        //    var result = xdoc.Element("Departments").Descendants();
        //    foreach (XElement item in result)
        //    {
        //        Console.WriteLine("Department name -" + item.Value);

        //    }
        //    Console.ReadLine();
        //}
        //public static void LINQReadXMLAddNode(string[] names)
        //{
        //    string myXML = @"<Departments>
        //               <Department>Account</Department>
        //               <Department>Sales</Department>
        //               <Department>Pre-Sales</Department>
        //               <Department>Marketing</Department>
        //               </Departments>";


        //    XDocument xdoc = new XDocument();
        //    xdoc = XDocument.Parse(myXML);

        //    // add new element
        //    xdoc.Element("Departments").Add(new XElement("Departments", "Finance"));

        //    // aa new elemnt at frist
        //    xdoc.Element("Departments").AddFirst(new XElement("Departments", "Support"));


        //    var result = xdoc.Element("Departments").Descendants();
        //    foreach (XElement item in result)
        //    {
        //        Console.WriteLine("Department name -" + item.Value);

        //    }
        //    Console.ReadLine();
        //}
        public static void LINQReadXMLDeleteNode(string[] names)
        {
            string myXML = @"<Departments>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       </Departments>";


            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //to remove 
            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();


            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department name - " + item.Value);

            }
            Console.ReadLine();
        }
    }
}
