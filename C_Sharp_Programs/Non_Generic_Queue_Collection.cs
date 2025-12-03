using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Non_Generic_Queue_Collection     //FIFO
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Enqueue("Neha");
            q1.Enqueue("Siya");
            q1.Enqueue(106);
            q1.Enqueue(102030);
            q1.Enqueue(true);
            Console.WriteLine("--------Enqueue Operation-------------");

            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count is:" + q1.Count);
            q1.Dequeue();
            Console.WriteLine("--------Dequeue Operation-------------");

            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count is:" + q1.Count);

            Console.WriteLine("---------------------");
            q1.Peek();
            Console.WriteLine("Peek element is:" + q1.Peek());

            Console.ReadLine();
        }
    }
}
