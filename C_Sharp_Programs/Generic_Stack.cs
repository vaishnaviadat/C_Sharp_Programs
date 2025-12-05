using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Generic_Stack
    {
        static void printnumbers(Stack<int> stack)
        {
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(101);
            stack.Push(102);
            stack.Push(103);
            stack.Push(104);
            stack.Push(105);
            stack.Push(106);
            Console.WriteLine("Stack elements:");

            printnumbers(stack);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
