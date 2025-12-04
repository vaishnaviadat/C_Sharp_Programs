using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Non_generic_Sorted_List_Collection
    {
        static void display_list(SortedList s1)
        {
            foreach(DictionaryEntry item in s1)
            {
                Console.WriteLine($"Id :{item.Key}, Name:{item.Value}");
            }
        }
        static void Main(string[] args)
        {
            SortedList l1=new SortedList();
            l1.Add(6, "vaishna");
            l1.Add(3, "prisha");
            l1.Add(1, "Saisha");
            l1.Add(2, "Ram");
            l1.Add(5, "Krishna");

            Console.WriteLine("----------Sorted List--------");
            display_list(l1);

            Console.WriteLine("Value of Key:" + l1[3]);
            Console.WriteLine("Value of Index:"+l1.GetByIndex(1));
            l1[4] = "Neha";
            display_list(l1);

            Console.WriteLine("----------Remove data--------");
            l1.Remove(1);
            display_list(l1);

            Console.WriteLine("\nCount is:" + l1.Count);
            Console.ReadLine();
        }
    }
}
