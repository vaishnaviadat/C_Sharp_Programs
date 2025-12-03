using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Non_Generic_Queue_Collection_Input_from_user
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            int choice;

            do
            {
                Console.WriteLine("\n----------- Queue Menu ------------");
                Console.WriteLine("1. Enqueue Element");
                Console.WriteLine("2. Dequeue Element");
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
                        Console.Write("Enter element to enqueue: ");
                        string input = Console.ReadLine();
                        q1.Enqueue(input);
                        Console.WriteLine($"{input} Added to Queue.");
                        break;

                    case 2:
                        if (q1.Count > 0)
                        {
                            var dequed = q1.Dequeue();
                            Console.WriteLine($"Remove element: {dequed}");
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty!");
                        }
                        break;

                    case 3:
                        if (q1.Count > 0)
                        {
                            var top = q1.Peek();
                            Console.WriteLine($"Top element (Peek): {top}");
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty!");
                        }
                        break;

                    case 4:
                        if (q1.Count > 0)
                        {
                            Console.WriteLine("Queue elements:");
                            foreach (var item in q1)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty!");
                        }
                        break;

                    case 5:
                        Console.Write("Enter element to check: ");
                        string check = Console.ReadLine();
                        bool exists = q1.Contains(check);
                        Console.WriteLine(exists ? "Element found." : "Element not found.");
                        break;

                    case 6:
                        Console.WriteLine($"Total elements in queue: {q1.Count}");
                        break;

                    case 7:
                        q1.Clear();
                        Console.WriteLine("Queue cleared!");
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
