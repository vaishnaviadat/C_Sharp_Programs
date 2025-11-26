using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    class employee
    {
        public string name;
        public int age;

        public double Grosssalary;
        double taxdeduction=0.1;
        double netsalary;

        public employee(string name, int age, double Grosssalary)
        {
            this.name = name;//same name use this keyword
            this.age = age;
            this.Grosssalary = Grosssalary;
        }
        private void calculatesalary()
        {
            if (Grosssalary > 30000)
            {
                netsalary = Grosssalary - (taxdeduction * Grosssalary);
                Console.WriteLine("your net salary is:" + netsalary);
            }
            else
            {
                Console.WriteLine("your net salary is:" + Grosssalary);
            }
        }
        public void showempdetails()
        {
            Console.WriteLine("Employee Name:" + name);
            Console.WriteLine("Employee Age:" + age);
            this.calculatesalary();
        }
    }
    internal class Abstraction_salary_example
    {
        static void Main(string[] args)
        {
            employee e1= new employee("Vaishna", 21, 50000);
            e1.showempdetails();
            Console.ReadLine();

        }
    }
}
