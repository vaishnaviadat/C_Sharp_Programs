using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Constructor_Overloading
    {
        public Constructor_Overloading()
        {
            Console.WriteLine("Default Constructor");
        }
        public Constructor_Overloading(int a,int b)
        {
            
            Console.WriteLine("Addition is=" +(a+b));
        }
        public Constructor_Overloading(int a, int b,string name)
        {
            Console.WriteLine("Value is:"+ (a,b,name));
        }
        static void Main(string[] args)
        {
            Constructor_Overloading c1=new Constructor_Overloading();
            Constructor_Overloading c2=new Constructor_Overloading(10,20);
            Constructor_Overloading c3 = new Constructor_Overloading(100,200,"Vaishna");

            Console.ReadLine();
        }
    }
}
