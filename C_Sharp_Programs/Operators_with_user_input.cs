using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Operators_with_user_input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n===================");
            Console.WriteLine("Arithmatic Operators");
            Console.WriteLine("===================");

            Console.WriteLine($"num1 + num2 = {num1 + num2}");//Addition
            Console.WriteLine($"num1 - num2 = {num1 - num2}");//Subtraction
            Console.WriteLine($"num1 * num2 = {num1 * num2}");//Multiplication
            Console.WriteLine($"num1 / num2 = {num1 / num2}");//Division
            Console.WriteLine($"num1 % num2 = {num1 % num2}");//Modulus
            Console.WriteLine("====================");

            Console.WriteLine("\n===================");
            Console.WriteLine("Relational Operators");
            Console.WriteLine("===================");

            Console.WriteLine($"num1 == num2 : {num1 == num2}");//Equal to
            Console.WriteLine($"num1 != num2 : {num1 != num2}");//Not Equal to
            Console.WriteLine($"num1 > num2 : {num1 > num2}");//Greater than
            Console.WriteLine($"num1 < num2 : {num1 < num2}");//Less than
            Console.WriteLine($"num1 >= num2 : {num1 >= num2}");//Greater than or Equal to
            Console.WriteLine($"num1 <= num2 : {num1 <= num2}");//Less than or Equal to
            Console.WriteLine("====================");

            Console.WriteLine("\n===================");
            Console.WriteLine("Logical Operators");
            Console.WriteLine("===================");
            bool x = (num1 > 0);
            bool y = (num2 > 5);
            Console.WriteLine($"x && y : {x && y}");//Logical AND
            Console.WriteLine($"x || y : {x || y}");//Logical OR
            Console.WriteLine($"!x : {!x}");//Logical NOT
            Console.WriteLine("====================");

            Console.WriteLine("\n===================");
            Console.WriteLine("Assignment Operators");
            Console.WriteLine("===================");
            int a = num1;
            a += num2;
            Console.WriteLine($"a += num2 : {a}");//Addition Assignment

            a -= num2;
            Console.WriteLine($"a -= num2 : {a}");//Subtraction Assignment

            a *= num2;
            Console.WriteLine($"a *= num2 : {a}");//Multiplication Assignment

            a /= num2;
            Console.WriteLine($"a /= num2 : {a}");//Division Assignment

            a %= num2;
            Console.WriteLine($"a %= num2 : {a}");//Modulus Assignment
            Console.WriteLine("====================");

            Console.WriteLine("\n===================");
            Console.WriteLine("Unary Operators");
            Console.WriteLine("===================");

            int b = num1;
            Console.WriteLine($"b++ : {b++}");//Post-increment
            Console.WriteLine($"++b : {++b}");//Pre-increment
            Console.WriteLine($"b-- : {b--}");//Post-decrement
            Console.WriteLine($"--b : {--b}");//Pre-decrement
            Console.WriteLine("====================");

            Console.WriteLine("\n===================");
            Console.WriteLine("Bitwise Operators");
            Console.WriteLine("===================");

            Console.WriteLine($"num1 & num2 : {num1 & num2}");//Bitwise AND
            Console.WriteLine($"num1 | num2 : {num1 | num2}");//Bitwise OR
            Console.WriteLine($"num1 ^ num2 : {num1 ^ num2}");//Bitwise XOR
            Console.WriteLine($"~num1 : {~num1}");//Bitwise NOT
            Console.WriteLine($"num1 << 1 : {num1 << 1}");//Left Shift
            Console.WriteLine($"num1 >> 1 : {num1 >> 1}");//Right Shift
            Console.WriteLine("====================");

            Console.WriteLine("\n===================");
            Console.WriteLine("Ternary Operator");
            Console.WriteLine("===================");

            string result = (num1 > num2) ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine($"Result: {result}");

            Console.WriteLine($"====================");

            Console.ReadLine();
        }

    }
}
