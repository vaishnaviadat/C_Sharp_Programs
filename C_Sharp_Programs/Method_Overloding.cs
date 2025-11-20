using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Method_Overloding
    {
            public void add()
            {
                int a = 10;
                int b = 20;
                int sum = a + b;
                Console.WriteLine("Sum is:" + sum);
            }
            public void add(int a, int b)
            {
                int sum = a + b;
                Console.WriteLine("Sum is:" + sum);

            }
        public void add(int a, int b,int c)
        {
            int sum = a + b+c;
            Console.WriteLine("Sum is:" + sum);

        }

        static void Main(string[] args)
        {
            Method_Overloding m=new Method_Overloding();
            m.add();
            m.add(11, 22);
            m.add(1, 2, 3);
            Console.ReadLine();
        }
    }
}
