using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    class  newclass
    {
        public string str;
        public int num;
        public static newclass operator +(newclass obj1,newclass obj2)
        {
            newclass obj3=new newclass();
            obj3.num = obj1.num + obj2.num;
            obj3.str = obj1.str + obj2.str;
            return obj3;
        }

    }
    internal class operator_overloading
    {

            static void Main(string[] args)
        {
            newclass obj1 = new newclass();
            newclass obj2 = new newclass();
            newclass obj3 = new newclass();

            obj1.str = "vaishna ";
            obj1.num = 100;

            obj2.str = "adat";
            obj2.num = 6;
            obj3 = obj1 + obj2;

            Console.WriteLine("Name is : " + obj3.str);
            Console.WriteLine("Id is : " + obj3.num);
            Console.ReadLine();
        }
    }
}
