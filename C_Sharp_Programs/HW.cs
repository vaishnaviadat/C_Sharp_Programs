using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class HW
    {
        public static void name1()  //no parameter no return -static
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Welcome, " + name + "!");
            Console.WriteLine("-------- Super Market Billing--------");
            Console.WriteLine();
        }
        
        public static void  item_info ()    //no parameter no return -static
        {
            Console.Write("Enter item name:");
            string item_name = Console.ReadLine();

            Console.Write("Enter item price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selected item:" + (item_name) + ",Price:" + (price)+" Per Unit");
            Console.WriteLine();

            Console.WriteLine("Enter Price Per Unit:" + (price));

            Console.Write("Enter Quantity:");
            double quantity = Convert.ToDouble(Console.ReadLine());

            double total_amount = price * quantity;
            Console.WriteLine("Total Amount (Without Discount):"+ (total_amount));
            Console.WriteLine();


            Console.Write("Enter Discount (%):");
            double discount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Final Payable Amount :" + (total_amount - (total_amount * discount / 100)));
            Console.WriteLine();

            Console.WriteLine("Thank You For Shopping!");

        }
       
        static void Main(string[] args)
        {
            
            HW.name1();
            HW.item_info();
            HW h = new HW();
            Console.ReadLine();
        }
        
    }
}
