using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter 1st Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine($"The Sum is:{sum}");//string interpolation
            Console.WriteLine("First number is:{0} and Second number is:{1}", num1, num2);//Placeholder
            Console.WriteLine("First number is:" + num1 + " and Second number is:" + num2);//Concatenation

            Console.ReadLine();

        }
    }
}
