using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Non_Generic_Stack2_Collection
    {
        static void Main(string[] args)

        {
            Stack s2 = new Stack();
            s2.Push("A");
            s2.Push("B");
            s2.Push("C");
            s2.Push("D");
            s2.Push("E");
            s2.Push("F");
            foreach (var item in s2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total Count"+s2.Count);

            s2.Pop();
            foreach (var item in s2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total Count" + s2.Count);

            Console.WriteLine("\n Top of stack(Peek):" + s2.Peek());
            Console.WriteLine("\n Removing:" + s2.Pop());
            foreach (var item in s2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total Count" + s2.Count);
            s2.Push("Geeta");
            foreach (var item in s2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total Count" + s2.Count);
            Console.WriteLine("\nConatains geeta" + s2.Contains("Geeta"));

            //s2.Clear();
            //Console.WriteLine("total count:" + s2.Count);
            Console.ReadLine();

        }
    }
}
