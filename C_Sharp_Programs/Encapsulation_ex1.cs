using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    class person11
    {
        private string name;
        private int age;
        private double marks;
        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("Name is Required");
            }
            else
            {
                this.name = name;
            }
        }
        public void getName()
        {
            if (string.IsNullOrEmpty(name)!= true)
            {
                Console.WriteLine("Name is:" + this.name);
            }

        }
        public void setAge(int age)
        {
            if (age<0)
            {
                Console.WriteLine("Age can not be negative");
            }
            else
            {
                this.age = age;
            }
        }
        public void getAge()
        {
            if (age>0)
            {
                Console.WriteLine("Age is:" + this.age);
            }

        }
        public void setMarks(double marks)
        {
            if(marks<0)
            {
                Console.WriteLine("Plz enter the 0 to 100");
            }
            else
            {
                this.marks = marks;
            }
        }
        public void getMarks()
        {
            if(marks>0)
            {
                Console.WriteLine("Marks is:" + this.marks);

            }
        }
    }
    internal class Encapsulation_ex1
    {
        static void Main(string[] args)
        {
            person11 p = new person11();
            p.setName("Vaishna");
            p.getName();
            p.setAge(21);
            p.getAge();
            p.setMarks(50);
            p.getMarks();
            //p.name = "Vaishna";
            //p.age = 21;
            //Console.WriteLine("Name is:"+p.name);
            //Console.WriteLine("Age is:"+p.age);
            Console.ReadLine();
        }

    }
}
