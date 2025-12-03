using System;
using System.Collections;

namespace C_Sharp_Programs
{
    internal class Non_Generic_Stack3_input_from_user
    {
        static void Main(string[] args)
        {
            Stack s3 = new Stack();
            int choice;

            do
            {
                Console.WriteLine("\n----------- Stack Menu ------------");
                Console.WriteLine("1. Push Element");
                Console.WriteLine("2. Pop Element");
                Console.WriteLine("3. Peek Element");
                Console.WriteLine("4. Display Elements");
                Console.WriteLine("5. Check Element (Contains)");
                Console.WriteLine("6. Count Elements");
                Console.WriteLine("7. Clear Stack");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice (1-8): ");

                // Valid input check
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter element to push: ");
                        string input = Console.ReadLine();
                        s3.Push(input);
                        Console.WriteLine($"{input} pushed to stack.");
                        break;

                    case 2:
                        if (s3.Count > 0)
                        {
                            var popped = s3.Pop();
                            Console.WriteLine($"Popped element: {popped}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty!");
                        }
                        break;

                    case 3:
                        if (s3.Count > 0)
                        {
                            var top = s3.Peek();
                            Console.WriteLine($"Top element (Peek): {top}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty!");
                        }
                        break;

                    case 4:
                        if (s3.Count > 0)
                        {
                            Console.WriteLine("Stack elements:");
                            foreach (var item in s3)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty!");
                        }
                        break;

                    case 5:
                        Console.Write("Enter element to check: ");
                        string check = Console.ReadLine();
                        bool exists = s3.Contains(check);
                        Console.WriteLine(exists ? "Element found." : "Element not found.");
                        break;

                    case 6:
                        Console.WriteLine($"Total elements in stack: {s3.Count}");
                        break;

                    case 7:
                        s3.Clear();
                        Console.WriteLine("Stack cleared!");
                        break;

                    case 8:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 8.");
                        break;
                }

            } while (choice != 8);  

            Console.ReadLine();
        }
    }
}
