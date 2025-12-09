using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Generic_HashSet_Collection
    {
        static void printfruits(HashSet<string> fruits)
        {
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Add("Grapes");
            fruits.Add("Apple"); // Duplicate,value  will not be added
            bool added= fruits.Add("Apple");
            Console.WriteLine("Was 'Apple' added again? " + added);
            Console.WriteLine("----------Fruit List-----------");
            printfruits(fruits);
            Console.ReadLine();
        }
    }
}
