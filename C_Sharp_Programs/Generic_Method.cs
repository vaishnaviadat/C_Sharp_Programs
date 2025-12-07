using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace C_Sharp_Programs
{
    class sample
    {
        public static void display <T>(T []a)
        {
            for(int i=0;i<a.Length;i++)
            {
              Console.WriteLine(a[i]);
            }
        }
    }
    internal class Generic_Method
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50 };
            sample.display(a);
            Console.ReadLine();
        }
    }
}
