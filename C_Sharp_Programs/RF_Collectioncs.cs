using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class RF_Collectioncs
    {
        //static void printarraylist(ArrayList a1)
        //{
        //    foreach(var i in a1)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //static void printstack(Stack s1)
        //{
        //    foreach(var i in s1)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        static void printqueue(Queue q1)
        {
            foreach(var i in q1)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[]args)
        {
            //Arraylist

            //ArrayList a1=new ArrayList();
            //a1.Add(10);
            //a1.Add("vaishna");
            //a1.Add(15);
            //a1.Add(1);
            //a1.Add(106);
            //Console.WriteLine("-------Arraylist elements----------");
            //printarraylist(a1);
            //Console.WriteLine();

            //Console.WriteLine("-----Arraylist elements after inserting element at index 3------");
            //a1.Insert(3, "Adat");
            //printarraylist(a1);
            //Console.WriteLine();

            //Console.WriteLine("-----Arraylist elements after removing element------");
            //a1.Remove("vaishna");
            //printarraylist(a1);
            //Console.WriteLine();

            //Console.WriteLine("-----Arraylist elements after removing element at index 2------");
            //a1.RemoveAt(2);
            //printarraylist(a1);
            //Console.WriteLine();

            //Console.WriteLine("-----Arraylist elements after sorting------");
            //a1.Sort();
            //printarraylist(a1);
            //Console.WriteLine();

            //Console.WriteLine("-----Arraylist elements after reversing------");
            //a1.Reverse();
            //printarraylist(a1);
            //Console.WriteLine();

            //Console.WriteLine("-----Arraylist Count------");
            //Console.WriteLine("Count is: " + a1.Count);
            //Console.WriteLine();

            //Console.WriteLine("-----Arraylist Contains------");
            //Console.WriteLine("Contains 106: " + a1.Contains(106));
            //Console.WriteLine();

            //Console.WriteLine("-----Arraylist ToArray------");
            //object[]array=a1.ToArray();
            //Console.WriteLine("to array is:"+ array);
            //Console.WriteLine();

            //Console.WriteLine("-----Arraylist Clear------");
            //a1.Clear();
            //printarraylist(a1); 
            //Console.WriteLine("clear element");

            //stack

            //Stack s1 = new Stack();
            //s1.Push(100);
            //s1.Push(200);
            //s1.Push("Vaishna");
            //s1.Push(300);
            //Console.WriteLine("---Stack Element:---");
            //printstack(s1);
            //Console.WriteLine();

            //s1.Pop();
            //Console.WriteLine("----Stack elements after pop----");
            //Console.WriteLine("pop element is: " + s1.Pop());
            //Console.WriteLine();

            //s1.Peek();
            //Console.WriteLine("----Stack elements after peek----");
            //Console.WriteLine("peek element is: " + s1.Peek());
            //Console.WriteLine();

            //Console.WriteLine("-----Stack Count------");
            //Console.WriteLine("Count is: " + s1.Count);
            //Console.WriteLine();

            //Console.WriteLine("-----Stack Contains------");
            //Console.WriteLine("Contains 200: " + s1.Contains(200));
            //Console.WriteLine();

            
            //Queue
            Queue q1= new Queue();
            q1.Enqueue(100);
            q1.Enqueue("Vaishna");
            q1.Enqueue(200);
            q1.Enqueue(300);

            Console.WriteLine("----Queue Elements:----");
            printqueue(q1);
            Console.WriteLine();

            Console.WriteLine("----Queue elements after Dequeue----");
            Console.WriteLine("Dequeue element is: " + q1.Dequeue());
            Console.WriteLine();

            Console.WriteLine("----Queue elements after Peek----");
            Console.WriteLine("Peek element is: " + q1.Peek());
            Console.WriteLine();

            Console.WriteLine("-----Queue Count------");
            Console.WriteLine("Count is: " + q1.Count);
            Console.WriteLine();

            Console.WriteLine("-----Queue Contains------");
            Console.WriteLine("Contains 200: " + q1.Contains(200));
            Console.WriteLine();



            Console.ReadLine();

        }
    }

}
