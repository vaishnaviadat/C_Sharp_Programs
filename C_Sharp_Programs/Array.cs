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
            int[] number = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            for(int i=0;i<number.Length;i++)
            {
                Console.WriteLine($"Elements index is:{i}= {number[i]}");
            }
            Console.ReadLine();
        }
        
    }
}
