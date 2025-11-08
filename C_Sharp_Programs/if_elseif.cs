using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class if_elseif
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer type:");
            string Cust_type=Console.ReadLine();
            if(Cust_type == "premium")
            {
                Console.WriteLine("Enter payment amount:");
                int pay_amount=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter pay_mode:");
                string pay_mode=Console.ReadLine();
                if(pay_amount>10000 && pay_mode=="cash" )
                {
                    Console.WriteLine("payment amount more than 10000 and discount:20%");
                }
                else if(pay_amount > 10000 && pay_mode == "card")
                {
                    Console.WriteLine("payment amount more than 10000 and discount:15%");
                }
                else if ((pay_amount < 10000 || pay_amount == 10000 ) && (pay_mode == "any"))
                {
                    Console.WriteLine(" payment amount 10000 or less and discount:10%");
                }
            }
            else 
            {
                Console.WriteLine("Enter payment amount:");
                int pay_amount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter pay_mode:");
                string pay_mode =(Console.ReadLine());
                if (pay_amount > 5000 && pay_mode == "cash")
                {
                    Console.WriteLine("payment amount more than 5000 and discount:5%");
                }
                else if (pay_amount > 5000 && pay_mode == "card")
                {
                    Console.WriteLine("payment amount more than 5000 and discount:3%");
                }
                else if ((pay_amount < 5000 || pay_amount == 5000) &&(pay_mode == "any"))
                {
                    Console.WriteLine(" payment amount 5000 or less and discount:no");
                }

            }
            Console.ReadLine();
        }
    }
}
