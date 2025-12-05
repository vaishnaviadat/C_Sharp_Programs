using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Generic_Queue_Collection
    {
        static void printnames(Queue<string>names)
        {
            foreach (var i in names)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Queue<string> q1 = new Queue<string>();
            Console.WriteLine("-----------Enqueue Elements----------");
            q1.Enqueue("Prisha");
            q1.Enqueue("Saisha");
            q1.Enqueue("Siya");
            q1.Enqueue("Neha");
            q1.Enqueue("Vaishnavi");

            printnames(q1);
            Console.WriteLine();

            Console.WriteLine("-----------Dequeue Elements----------");
            Console.WriteLine("Dequeue element is: "+q1.Dequeue());
            Console.WriteLine();
            Console.WriteLine("-------Queue Elements After Dequeue------");
            printnames(q1);
            Console.WriteLine() ;

            Console.WriteLine("----------Peek Elements---------");
            Console.WriteLine("Peek element is: " + q1.Peek());
            Console.WriteLine();

            Console.WriteLine("-----------Clear-----------");
            q1.Clear();
            printnames(q1);
            Console.WriteLine("Cleared Elements");
            Console.WriteLine();

            Console.WriteLine("-----------Count-----------");
            Console.WriteLine("Count is:"+q1.Count());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
