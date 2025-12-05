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

            Console.WriteLine("----------Current List-----------");
            printcitylist(citylist);

            Console.WriteLine("--------Add Range-----------");
            citylist.AddRange(new List<string> { "Sydney", "Tokyo", "Beijing" });//add multiple value at time
            printcitylist(citylist);

            Console.WriteLine("--------Insert at Index-----------");
            citylist.Insert(2, "Berlin");//insert value at index 2
            printcitylist(citylist);

            Console.WriteLine("Insert Range");
            citylist.InsertRange(1,new List<string> {"Solapur","Akluj","Velapur"});  
            printcitylist(citylist);

            Console.WriteLine("-----------Remove City------------");
            citylist.Remove("Mumbai");
            printcitylist(citylist);

            Console.ReadLine();
        }
    }
}
