using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Generic_DictionaryList_Collection
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(101, "Siya");
            dict.Add(102, "Radha");
            dict.Add(103, "Rani");
            dict.Add(104, "Ram");
            dict.Add(105, "Anjali");
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine("Key:{0},Value:{1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();
        }
    }
}
