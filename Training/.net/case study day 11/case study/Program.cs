using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No_6
{
    class Student
    {
        public int id;
        public string name;
        public string dob;

        public Student(int id, string name, string dob)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
        }
        public Student()
        {

        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setDob(string dob)
        {
            this.dob = dob;
        }
        public string getdob()
        {
            return dob;
        }
        public class Info
        {
            // display of details of students
            public void display(Student student1, Student student2, Student student3, Student student4)
            {
                Console.WriteLine("details of students are; ");
                Console.WriteLine($"name of student is {student1.getName()} of Id {student1.getId()} and dob {student1.getdob()}");
                Console.WriteLine($"name of student is {student2.getName()} of Id {student2.getId()} and dob {student2.getdob()}");
                Console.WriteLine($"name of student is {student3.getName()} of Id {student3.getId()} and dob {student3.getdob()}");
                Console.WriteLine($"name of student is {student4.getName()} of Id {student4.getId()} and dob {student4.getdob()}");

            }
        }
        public class App
        {
            public void detail()
            {
                Student student1 = new Student(111, "Manoj Birajdar", "18/09/1999");
                Student student2 = new Student(222, "Ram Pawar", "22/06/2000");
                Student student3 = new Student(333, "Rohan Tiwari", "15/07/1998");
                Student student4 = new Student(444, "Rahul Shinde", "02/06/1999");

                Info info = new Info();
                info.display(student1, student2, student3, student4);
            }
            public void details()
            {
                Student[] arr = new Student[4];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Student(555, "Ganesh Sagar", "05/11/1999");

                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        public static void Main(string[] args)
        { 
            App app = new App();
            app.detail();
            app.details();
            Console.ReadLine();
        }
        
        

    }
}
