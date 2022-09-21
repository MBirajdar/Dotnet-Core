using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson
{
    internal class program
    {
        public void sumAverageElements(int[] arr,int size )
        {
            Console.WriteLine("enter the array size");
            int num = int.Parse(Console.ReadLine());
            int[] ar = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("enter data");
                int data = int.Parse(Console.ReadLine());
                ar[i] = data;
            }
            Console.WriteLine("--your data--");
            foreach(int i in ar) 
            {
                Console.WriteLine(i);

            }
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            Console.WriteLine("Sum Of Array is : " + sum);
            Console.WriteLine("Average Of Array is : " + average);
            Console.ReadLine();
            Console.ReadLine();
            int len = ar.Length;
            program pg = new program();
            pg.sumAverageElements(ar, len);





        }
    }
}
