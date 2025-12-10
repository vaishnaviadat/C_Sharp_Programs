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
          try
            {
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                
                int result = num1 / num2;
                Console.WriteLine("Division is: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some Error occured:"+e.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
            Console.ReadLine();
        }
    }
}
