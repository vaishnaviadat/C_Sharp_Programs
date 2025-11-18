using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
                    //non-static=create object
                    //static =not create object
    internal class rfpagecs
    {   //withparameter with return-static
        public static int  add(int a,int b)
        {
            return a + b;
        }
        //withparameter with return- non static
        public int div2(int a,int b)
        {
            return a / b;
        }
        //withparameter no return-static
        public static void sub(int a,int b)
        {
            Console.WriteLine("sub is=" + (a - b));
        }

        //withparameter no return- non static
        public void sun3(int a,int b)
        {
            Console.WriteLine("sub is=" + (a - b));
        }
        //noparameter with return-static
        public static int multi()
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());
            return num1*num2;
        }

        //noparameter with return- non static
        public int multi1()
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());
            return num1 * num2;
        }
        //no parameter,no return -static
        public static void div()
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("division is="+(num1/num2));
        }
        //no parameter,no return -non static
        public void add1()
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("addition is=" + (num1+num2));

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number:");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2=int.Parse(Console.ReadLine());

            //int res = add(num1, num2);//static(return)
            //Console.WriteLine("addition is=" + res);

            //rfpagecs.sub(num1, num2);//static(no return)

            //int res_m = multi();
            //Console.WriteLine("Multiplication is=" + res_m);

            //div();

            //rfpagecs r=new rfpagecs();//(non-static,no return)
            //r.add1();

            //rfpagecs r1 = new rfpagecs();//(non-static,no return)
            //r1.sun3(num1, num2);

            //rfpagecs r2 = new rfpagecs();//(non-static,return)
            //Console.WriteLine("Multiplication is=" + r2.multi1());

            rfpagecs r2 = new rfpagecs();//(non-static,return)
            int res_d = r2.div2(num1, num2);
            Console.WriteLine("division is=" + res_d);

            Console.ReadLine();

           

            
        }
    }
}
