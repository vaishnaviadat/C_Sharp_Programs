using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    abstract class person
    {
        public long phone_no;
        public string name;
        public int age;

        public abstract void printdetails(); // abstract method

        public void display()   // non abstract method
        {
            Console.WriteLine("non abstract method");
        }
    }
 class student11:person
    {
        public int roll_no;
        public int fees;
        public override void  printdetails()
        {
            Console.WriteLine("Student name:" + name);
            Console.WriteLine("Student age:" + age);
            Console.WriteLine("Student phone_no:" + phone_no);
            Console.WriteLine("Student roll_no:" + roll_no);
            Console.WriteLine("student fees:" + fees);
        }
    }

    abstract class teacher
    {
        public int Teach_salary;
        public string Teach_qulification;
        public abstract void printdetails1(); // abstract method

    }
    class student110 : teacher
    {
        public override void printdetails1()
        {
            Console.WriteLine("teacher salary:" + Teach_salary);
            Console.WriteLine("teacher qulification:" + Teach_qulification);

        }

    }
    internal class Abstract_Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Student details------");
            student11 s=new student11();
            s.phone_no = 1122334455;
            s.name = "Vaishnaa";
            s.age = 21;
            s.roll_no = 106;
            s.fees = 500;
            s.printdetails();

            Console.WriteLine("-----Teacher details------");
            student110 s1=new student110();
            s1.Teach_salary = 50000;
            s1.Teach_qulification = "D.Ed";
            s1.printdetails1();

            Console.ReadLine();
        }
    }
}
