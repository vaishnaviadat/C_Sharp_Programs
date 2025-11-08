using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class if_else
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your Age:");
            //int age=Convert.ToInt32(Console.ReadLine());
            //if(age>=18)
            //{
            //    Console.WriteLine("Eligible for vote");
            //}
            //else
            //{
            //    Console.WriteLine("Not Eligible for vote");
            //}

            //Console.WriteLine("Enter String:");
            //string name=Console.ReadLine();
            //string name1 = "vaishna";
            //if(name==name1)
            //{
            //    Console.WriteLine("Welcome");
            //}
            //else
            //{
            //    {
            //        Console.WriteLine("who are you");
            //    }
            //}
            //Console.WriteLine("Enter Username:");
            //string user_name = Console.ReadLine();
            //Console.WriteLine("Enter Password:");
            //string password = Console.ReadLine();
            //if(user_name == "vaishna" && password=="abcd")
            //{
            //    Console.WriteLine("Login Succesfully");
            //}
            //else
            //{
            //    Console.WriteLine("wrong credital");
            //}
            Console.WriteLine("Enter number:");
            int num1=int.Parse(Console.ReadLine());
            if(num1>0)
            {
                Console.WriteLine("Positive number");
            }
            else if(num1<0)
            {
                Console.WriteLine("Negative  number");
            }
            else
            {
                Console.WriteLine("netural");
            }
                Console.ReadLine();
        }

    }
}
