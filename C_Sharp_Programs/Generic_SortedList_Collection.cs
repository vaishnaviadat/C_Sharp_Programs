using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Generic_SortedList_Collection
    {
        static void printSortedList<TKey, TValue>(SortedList<TKey, TValue> sortedList)
        {
            foreach (var kvp in sortedList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
        }
        static void Main(string[] args)
        {
            // Creating a SortedList of int keys and string values
            SortedList<int, string>students = new SortedList<int, string>();
            // Adding key-value pairs to the SortedList
            students.Add(3, "Alice");
            students.Add(1, "Bob");
            students.Add(2, "Charlie");

            // Displaying the SortedList
            Console.WriteLine("--------SortedList of Students---------");
            printSortedList(students);
            Console.WriteLine();

            Console.WriteLine("---------Contains Students--------");
            Console.WriteLine("Contains key 2: " + students.ContainsKey(2));
            Console.WriteLine("Contains value 'David': " + students.ContainsValue("David"));
            Console.WriteLine();

            Console.WriteLine("---------Remove Student with key 1--------");
            students.Remove(1);
            Console.WriteLine("After removing key 1:");
            printSortedList(students);
            Console.WriteLine();

            Console.WriteLine("---------Count of Students--------");
            Console.WriteLine("Total students: " + students.Count);
            Console.WriteLine();

            Console.WriteLine("---------Access Student by Key 3--------");
            Console.WriteLine("Student with key 3: " + students[3]);
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
