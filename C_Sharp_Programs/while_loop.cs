using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class while_loop
    {
        static void Main(string[] args)
        {
            //print 1 to 5 number
            //int num1 = 1;
            //while(num1<=5)
            //{
            //    Console.WriteLine(num1);
            //    num1++;
            //}

            //print sum of n number
            //Console.WriteLine("Enter number=");
            //int num1 =int.Parse(Console.ReadLine());
            //int sum1 = 0;
            //int i = 1;
            //while(i<=num1)
            //{

            //    sum1 += i;
            //    i++;
            //}
            //Console.WriteLine("sum is=" + sum1);


            //Reverse number
            //Console.WriteLine("Enter number:");
            //int num1=int.Parse(Console.ReadLine());
            //int temp = num1;
            //int r,sum=0;
            //while(temp>0)
            //{
            //    r = temp % 10;
            //    sum = (sum * 10) + r;
            //    temp = temp / 10;
            //}
            //Console.WriteLine("Reverse number is="+sum);

            // Do While Loop
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <=5);

            Console.ReadLine();

        }
    }
}
