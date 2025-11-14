using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class function_types
    {
        //no parameter ,no return - static
        public static void showMgs()
        {
            Console.WriteLine("Hello from static method with no parameter and no return type");
        }
        //no parameter ,no return - non-static
        public  void showMgs1()
        {
            Console.WriteLine("Hello from non-static method with no parameter and no return type");
        }
        //withparameter,no return-static
        public static void showMgs2(int num1)
        {
            Console.WriteLine("value is=" + num1);
        }
        //withparameter,no return-non-static
        public void showMgs3(int num2)
        {
            Console.WriteLine("value is=" + num2);
        }
        //no parameter with return values using static
        public static int get_number()
        {
            return 15;
            
        }
        //no parameter with return values using non static
        public  int get_number1()
        {
            return 15;

        }
        //withparameter with return values using static
        public static int add(int a,int b)
        {
            return a+b;

        }
        //withparameter with return values using non-static
        public  int sub1(int a, int b)
        {
            return a - b;

        }
        static void Main(string[] args)
        {
            function_types.showMgs();//non-static
            function_types f=new function_types();//static
            f.showMgs1();
            function_types.showMgs2(106);
            f.showMgs3(101);
            Console.WriteLine("number is="+get_number());//static
            Console.WriteLine("number is=" + f.get_number1());//non
            int sum = add(1, 2);
            Console.WriteLine("sum is=" + sum);
            int substarction =f.sub1(3, 1);
            Console.WriteLine("sub is=" + substarction);
            Console.ReadLine();
        }

      
    }
      
}
