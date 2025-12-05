using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Generic_DictionaryList_Collection
    {
        static void stulist(Dictionary<int, string> dict)
        {
            foreach (var i in dict)
            {
                Console.WriteLine("ID:{0} Name:{1}", i.Key, i.Value);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(101, "Siya");
            dict.Add(102, "Radha");
            dict.Add(103, "Rani");
            dict.Add(104, "Ram");
            dict.Add(105, "Anjali");
           
            Console.WriteLine("-------Student List--------");
            stulist(dict);
            Console.WriteLine();

            Console.WriteLine("-------Contains Key--------");//Check key is present or not
            Console.WriteLine("Contains Key 103: " + dict.ContainsKey(103));
            Console.WriteLine();

            Console.WriteLine("-------Contains Value--------");//Check value is present or not
            Console.WriteLine("Contains Value 'Prisha': " + dict.ContainsValue("Prisha"));
            Console.WriteLine();

            Console.WriteLine("-------Update Value--------");
            dict[104] = "Saisha";//Update value at key 104
            stulist(dict);
            Console.WriteLine();

            Console.WriteLine("-------Remove Index--------");
            dict.Remove(103);//Remove key 102
            stulist(dict);
            Console.WriteLine();

            Console.WriteLine("--------only keys---------");//print only keys
            foreach (var key in dict.Keys)
            {
                Console.WriteLine("Key:"+key);
            }
            Console.WriteLine();

            Console.WriteLine("--------only Values---------");//print only Values
            foreach (var value in dict.Values)
            {
                Console.WriteLine("Value:" + value);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
