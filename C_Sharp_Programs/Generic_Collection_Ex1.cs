using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Generic_Collection_Ex1
    {
        static void printcitylist(List<string> citylist)
        {
            Console.WriteLine("----------Current List-----------");
            foreach (string i in citylist)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            List<string> citylist = new List<string>();
            citylist.Add("London");
            citylist.Add("New York");
            citylist.Add("Mumbai");
            citylist.Add("Pune");
            citylist.Add("New Delhi");
           
            printcitylist(citylist);
            Console.ReadLine();
        }
    }
}
