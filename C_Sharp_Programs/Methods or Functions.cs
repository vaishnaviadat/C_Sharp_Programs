using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Methods_or_Functions
    {
        public void show()//non-static method//instance method
        {
            Console.WriteLine("Hello from non-static method");
        }
        public static void demo()
        {
            Console.WriteLine("Hello from static method");
        }
        static void Main(string[] args)
        {
            demo();//calling static method
            Methods_or_Functions s=new Methods_or_Functions();
            s.show();//calling non-static method

            
            Console.ReadLine();
        }
        
    }
}
