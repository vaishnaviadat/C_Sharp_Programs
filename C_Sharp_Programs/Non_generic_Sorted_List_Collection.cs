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
            Console.WriteLine("----------Sorted List--------");
            display_list(l1);
            Console.ReadLine();
        }
    }
}
