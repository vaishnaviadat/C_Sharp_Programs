using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class RF_Collectioncs
    {
        static void printarraylist(ArrayList a1)
        {
            foreach(var i in a1)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[]args)
        {
            //Arraylist
            ArrayList a1=new ArrayList();
            a1.Add(10);
            a1.Add("vaishna");
            a1.Add(15);
            a1.Add(1);
            a1.Add(106);
            Console.WriteLine("-------Arraylist elements----------");
            printarraylist(a1);
            Console.WriteLine();

            Console.WriteLine("-----Arraylist elements after inserting element at index 3------");
            a1.Insert(3, "Adat");
            printarraylist(a1);
            Console.WriteLine();

            Console.WriteLine("-----Arraylist elements after removing element------");
            a1.Remove("vaishna");
            printarraylist(a1);
            Console.WriteLine();

            Console.WriteLine("-----Arraylist elements after removing element at index 2------");
            a1.RemoveAt(2);
            printarraylist(a1);
            Console.WriteLine();

            Console.WriteLine("-----Arraylist elements after sorting------");
            a1.Sort();
            printarraylist(a1);
            Console.WriteLine();

            Console.WriteLine("-----Arraylist elements after reversing------");
            a1.Reverse();
            printarraylist(a1);
            Console.WriteLine();

            Console.WriteLine("-----Arraylist Count------");
            Console.WriteLine("Count is: " + a1.Count);
            Console.WriteLine();

            Console.WriteLine("-----Arraylist Contains------");
            Console.WriteLine("Contains 106: " + a1.Contains(106));
            Console.WriteLine();

            Console.WriteLine("-----Arraylist ToArray------");
            object[]array=a1.ToArray();
            Console.WriteLine("to array is:"+ array);
            Console.WriteLine();

            Console.WriteLine("-----Arraylist Clear------");
            a1.Clear();
            printarraylist(a1); 
            Console.WriteLine("clear element");
            Console.ReadLine();

        }
    }

}
