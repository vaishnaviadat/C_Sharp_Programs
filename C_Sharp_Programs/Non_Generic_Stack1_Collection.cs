using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs  //LIFO
{
    internal class Non_Generic_Stack1_Collection
    {
        static void Main(string[] args)

        {
            Stack s1=new Stack();
            s1.Push("Apple");
            s1.Push(106);
            s1.Push(15.5);
            s1.Push(true);
            s1.Push("Hello World");
            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Total Count"+s1.Count);//push 
            Console.WriteLine("--------------");

            s1.Pop();
            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Total Count" + s1.Count);//pop 1st remove hot
            Console.ReadLine();
        }
    }
}
