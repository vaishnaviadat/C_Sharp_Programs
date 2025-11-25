using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//namespace Access_specifier

    //public access specifier

    //public class class1
    //{
    //    public void display()
    //    {
    //        Console.WriteLine("This is public access specifier");
    //    }
    //    //public void show()       // current class
    //    //{
    //    //    class1 obj= new class1();
    //    //    obj.display();
    //    //}
    //}
    //public class Program1:class1
    //{
    //    static void Main(string[] args)
    //    {
    //        //class1 obj= new class1();   
    //        //obj.show();

    //        Program1 obj1 = new Program1();
    //        obj1.display();
    //        Console.ReadLine();
    //    }
    //}

    // private access specifier
    public class class1
    {
        private void display()
        {
            Console.WriteLine("This is private class");
        }
        public void display1()
        {
            class1 obj = new class1();
            obj.display();
        }
    }
    public class Program1
    {
        static void Main(string[] args)
        {
            class1 obj= new class1();   
            obj.display1();
            Console.ReadLine();
        }
    }

