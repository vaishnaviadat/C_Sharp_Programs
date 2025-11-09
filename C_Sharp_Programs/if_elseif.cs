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
            Console.WriteLine("Enter customer type(premium/Regular):");
            string Cust_type=Console.ReadLine();
            if(Cust_type == "premium")
            {
                Console.WriteLine("Enter payment amount:");
                int pay_amount=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter pay_mode(cash/card/any):");
                string pay_mode=Console.ReadLine();
                if(pay_amount>=10000 && pay_mode=="cash" )
                {
                    Console.WriteLine("your discount is:20%");
                }
                else if(pay_amount >=10000 && pay_mode == "card")
                {
                    Console.WriteLine("your discount is:15%");
                }
                else if ((pay_amount <= 10000 || pay_amount == 10000 ) && (pay_mode == "any"))
                {
                    Console.WriteLine(" your discount is:10%");
                }
                else
                {
                    Console.WriteLine("Invalid customer type");
                }
            }
            else if(Cust_type == "regular")
            {
                Console.WriteLine("Enter payment amount:");
                int pay_amount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter pay_mode(cash/card/any):");
                string pay_mode =(Console.ReadLine());
                if (pay_amount >=5000 && pay_mode == "cash")
                {
                    Console.WriteLine("your discount is:5%");
                }
                else if (pay_amount >=5000 && pay_mode == "card")
                {
                    Console.WriteLine("Your discount is:3%");
                }
                else if ((pay_amount <= 5000 || pay_amount == 5000) &&(pay_mode == "any"))
                {
                    Console.WriteLine(" Your discount is:no discount");
                }
                else
                {
                    Console.WriteLine("Invalid customer type");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
                Console.ReadLine();
        }
    }
}
