using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Access_specifier;

namespace Access_specifier2
{
    //internal class Program2
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("this is second project");
    //        class1 obj = new class1();
    //        obj.display();
    //        Console.ReadLine();
    //    }
    //}


    internal class Program2:class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is second project-using derived class");
            Program2 obj = new Program2();
            obj.display();
            Console.ReadLine();
        }
    }
}
