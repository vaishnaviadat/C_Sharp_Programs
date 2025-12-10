using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Exception_EX1
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int result = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
            Console.ReadLine();
        }
    }
}
