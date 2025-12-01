using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    class BankAccount
    {
        private string accountholder_name;
        private string accountnumber;
        private double balance;
        public void createaccount()
        {
            Console.WriteLine("Enter account holder name:" + accountholder_name);
            accountholder_name = Console.ReadLine();
            Console.WriteLine("Enter account number:");
            accountnumber = Console.ReadLine();
            Console.WriteLine("Enter opening balance:");
            balance=Convert.ToDouble(Console.ReadLine());
        }
        public void deposit()
        {
            Console.WriteLine("Enter deposite amount:");
            double amount = Convert.ToDouble(Console.ReadLine());   

            if(amount>0)
            {
                balance += amount;
                Console.WriteLine("Amount deposit successfully");
            }
            else
            {
                Console.WriteLine("Invaild deposit amount");
            }
        }
        public void withdraw()
        {
            Console.WriteLine("Enter withdraw amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            if(amount>0 && amount<=balance)
            {
                balance-=amount;
                Console.WriteLine("Amount withdraw is:");
            }
            else
            {
                Console.WriteLine("Insufficent balance");
            }
        }
        public void showaccoutinfo()
        {
            Console.WriteLine("-----Account Summary-----");
            Console.WriteLine("Account holder name:" + accountholder_name);
            Console.WriteLine("Account number:" + accountnumber);
            Console.WriteLine("Current balance:" + balance);
        }
    }
    internal class Encapsulation_ex2
    {
        static void Main(string[] args)

        {
            BankAccount b=new BankAccount();
            b.createaccount();
            b.deposit();
            b.withdraw();
            b.showaccoutinfo();
            Console.ReadLine();
        }
    }
}
