using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Array
    {
        static void Main(string[] args)
        {
            // show index with elements
            //int[] number = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //for(int i=0;i<number.Length;i++)
            //{
            //    Console.WriteLine($"Elements index is:{i}= {number[i]}");
            //}

            //input from user
            //int[] mark = new int[5];
            //Console.WriteLine("Enter Marks:"); 
            //for(int i=0;i<mark.Length;i++)
            //{
            //    Console.WriteLine($"Enter mark for subject {i+1}:");
            //    mark[i]=int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enterd Marks:");

            //for (int i=0;i<mark.Length;i++)
            //{
            //    Console.WriteLine($"Marks for subject {i+1}: {mark[i]}");
            //}

            //String
            string[] name = { "riya", "radha", "siya", "prisha" };
            Console.WriteLine("Names in array:");
            foreach(string i in name)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
        
    }
}
