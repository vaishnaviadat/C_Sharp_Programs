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
        public Constructor_types()//Default Constructor
        {
            Console.WriteLine("hello world");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            
            Constructor_types c = new Constructor_types();
        }
    }
}
