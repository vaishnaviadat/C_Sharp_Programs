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
            //string[] name = { "riya", "radha", "siya", "prisha" };
            //Console.WriteLine("Names in array:");
            //foreach(string i in name)
            //{
            //    Console.WriteLine(i);
            //}

            //object[] obj = { "vaishna", 106, 99.99, true };
            //Console.WriteLine("mixed array:");
            //for(int i=0;i<obj.Length; i++)
            //{
            //    Console.WriteLine(obj[i]);
            //}


            //Multidimentional  Array
            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7,8,9} };
            //Console.WriteLine("Multidimentional Array:");
            //for(int i=0;i<3;i++)
            //{
            //    for(int j=0;j<3;j++)
            //    {
            //        Console.Write(arr[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            Console.WriteLine("Enter 2 Students Marks:");
            int[,] mark = new int[2, 3]; // 2 students, 3 subjects each

            // Input marks
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter Marks {j + 1}: ");
                    mark[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Display marks
            Console.WriteLine("\nMarks entered:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Subject {j + 1}: {mark[i, j]}");
                }
            }

            Console.ReadLine();
        }
    }
}

