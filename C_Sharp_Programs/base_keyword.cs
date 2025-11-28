using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    public class  parent
    {
        public parent(int a)
        {
            Console.WriteLine("This is parent class constructor"+ a);
        }
        //public void display() -- method
        //{
        //    Console.WriteLine("This is parent class method");
        //}
    }
    public class child : parent
    {
        public child(int a) : base(a)   // -- base keyword use to access parent class constructor
        {
            Console.WriteLine("This is child class constructor");
        }
        //public void show()    -- method
        //{
        //    base.display(); // -- base keyword use to access parent class method
        //    Console.WriteLine("This is child class method");
        //}
    }
    internal class base_keyword
    {
        static void Main(string[] args)
        {
            //child c= new child();
            //c.show();

            child c1 = new child(106);
            Console.ReadLine();
        }

    }
}
