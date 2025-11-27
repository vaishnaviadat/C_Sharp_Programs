using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    public class employee1
    {
        public int num1;
        public void dis(int num1)
        {
            this.num1 = num1;             // -- this keyword use with variable
        }
        public void show()
        {
            this.dis(106);//                -- this keyword use with method
            Console.WriteLine("value is=" + num1);
            
        }
        // Constructor
        //public employee1(int id)
        //{
        //    Console.WriteLine("first constructoe:" + id);
        //}
        //public employee1():this(106)      -- this keyword use with constructor
        //{
        //    Console.WriteLine("Second constructoe");
        //}
    }
    internal class this_keyword 
    {
        static void Main(string[] args)
        {
               // employee1 e=new employee1();  
               employee1 e1= new employee1();
               e1.show();
               Console.ReadLine();
        }
    }
}
