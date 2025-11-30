using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Interface_ex2
    {
        public interface IPayment
        {
            void Pay(string from, string to, double amount);

            void SentReceipt(string to, double amount);

            void LogPayment(string method, string status, DateTime time);
        }
        class CreditCardPayment : IPayment
        {
            public void Pay(string from, string to, double amount)
            {
                Console.WriteLine($"Paid {amount} from {from} to {to} using Credit Card.");
            }
            public void SentReceipt(string to, double amount)
            {
                Console.WriteLine($"Sent receipt of {amount} to {to} for Credit Card payment.");
            }
            public void LogPayment(string method, string status, DateTime time)
            {
                Console.WriteLine($"Payment Method: {method}, Status: {status}, Time: {time}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------Payment Details------");
            IPayment payment = new CreditCardPayment();
            payment.Pay("Alice", "John", 180.75);
            payment.SentReceipt("John", 180.75);
            payment.LogPayment("Credit Card", "Successful", DateTime.Now);
            Console.ReadLine();
        }

    }
}
