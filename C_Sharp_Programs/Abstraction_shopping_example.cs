using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    class OrderPayment
    {
        public string Cust_name;
        private string Product_name;
        private double Product_Price;
        private double Tax=0.01;
        private double Processing_Fee = 25;
        private double Total_Paybleamount;

        public OrderPayment(string Cust_name, string Product_Name,double Product_Price)
        {
            this.Cust_name = Cust_name;
            this.Product_name = Product_Name;
            this.Product_Price = Product_Price;
        }
        private void ProcessPayment()
        {
            double taxamount = Product_Price * Tax;
            Total_Paybleamount = Product_Price + taxamount + Processing_Fee;

            Console.WriteLine("Tax :" +taxamount);
            Console.WriteLine("Processing fee :" +Processing_Fee);
            Console.WriteLine("Total amount :" + Total_Paybleamount);
        }
        public void PlaceOrder()
        {
            Console.WriteLine("Customer name :" + Cust_name);
            Console.WriteLine("Product name:" + Product_name);
            Console.WriteLine("Product price:" + Product_Price);
            this.ProcessPayment();
        }
    }
    internal class Abstraction_shopping_example
    {
        static void Main(string[] args)

        {
            OrderPayment obj1 = new OrderPayment("Vaishna","TV",50000);
            obj1.PlaceOrder();
            Console.ReadLine();

        }
    }
}
