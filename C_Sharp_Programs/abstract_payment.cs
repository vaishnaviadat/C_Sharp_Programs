using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    abstract class payment
    {
        public double amount;
        public string customername;

        public void showbasicinfo() //non-abstract
        {
            Console.WriteLine("customer name:"+customername);
            Console.WriteLine("customer amount:"+amount);
        }
        public abstract void processpayment();  //abstract
    }

    class creditcardpayment:payment
    {
        public string cardnumber;
        public override void processpayment()
        {
            Console.WriteLine("Processing creditcard payment using cardnumber:"+cardnumber);
            Console.WriteLine("creditcard payment successfully");
        }
    }
    class upipayment : payment
    {
        public string upiId;
        public override void processpayment()
        {
            Console.WriteLine("Processing creditcard upipayment using :" + upiId);
            Console.WriteLine("UPI payment successfully");
        }
    }
    class netbankingpayment : payment
    {
        public string bankname;
        public override void processpayment()
        {
            Console.WriteLine("Processing netbanking payment using cardnumber:" + bankname);
            Console.WriteLine("netbanking payment successfully");
        }
    }
    internal class abstract_payment
    {
        static void Main(string[] args)

        {
            payment p1 = new creditcardpayment
            {
                customername = "john",
                amount=40000,
                cardnumber="1234-6789-1010"
            };
            Console.WriteLine("-----credit card payment-----");


            p1.showbasicinfo();
            p1.processpayment();

            payment p2 = new upipayment
            {
                customername = "john",
                amount = 50000,
                upiId = "abc@sbi",
            };
            Console.WriteLine("-----UPI payment-----");

            p2.showbasicinfo();
            p2.processpayment();

            payment p3 = new netbankingpayment
            {
                customername = "john",
                amount = 60000,
                bankname ="Baroda"
            };
            Console.WriteLine("-----UPI payment-----");

            p3.showbasicinfo();
            p3.processpayment();

            Console.ReadLine();
        }
    }
}
