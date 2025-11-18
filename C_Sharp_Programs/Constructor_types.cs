using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Constructor_types
    {
        string Name;
        int EMP_id;
        int Salary;
        public Constructor_types()//Default Constructor
        {
            Console.WriteLine("hello world");
            
        }
        public Constructor_types(string name,int emp_id,int salary)//Parameterized Constructor
        {
            Name= name;
            EMP_id= emp_id;
            Salary= salary;

        }
        public string getName()
        {
            return Name;
        }
        public int getEMP_id()
        {
            return EMP_id;
        }
        public int getSalary()
        {
            return Salary;
        }
        public string getdetails()
        {
            return $"Name:{Name},EMP_id:{EMP_id},Salary:{Salary}";
        }
        public void display()
        {
            Console.WriteLine("Emp name is:" + Name);
            Console.WriteLine("Emp id is:" + EMP_id);
            Console.WriteLine("Emp salary is:" + Salary);

        }
        static void Main(string[] args)
        {

            //Constructor_types c = new Constructor_types();
            Constructor_types c1 = new Constructor_types("Vaishna",106,50000);
            Console.WriteLine(c1.getName());
            Console.WriteLine(c1.getEMP_id());
            Console.WriteLine(c1.getSalary());
            c1.getdetails();
            c1.display();
            Console.ReadLine();
        }
    }
}
