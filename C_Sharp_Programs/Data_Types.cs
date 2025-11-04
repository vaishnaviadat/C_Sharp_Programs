using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Data_Types
    {
        static void Main(string[] args)
        {
            //Value Type
            int age = 21;//Interger Type
            float height = 5.9f;//Float Type
            double weight = 65.5;//Double Type
            char grade = 'V';//Character Type
            string name = "vaishna";//String Type
            bool isStudent = true;//Boolean Type
            decimal price = 99.99m;//Decimal Type
            Console.WriteLine("Age is: " + age);
            Console.WriteLine("Height is: " + height);
            Console.WriteLine("Weight is: " + weight);
            Console.WriteLine("Grade is: " + grade);
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Is Student: " + isStudent);
            Console.WriteLine("Price is: " + price);


            //Reference Type
            object obj = 106;//Object Type (object hold the value of any data type)
            Console.WriteLine("Object Value is: " + obj);

            Console.ReadLine();

        }

    }
}
