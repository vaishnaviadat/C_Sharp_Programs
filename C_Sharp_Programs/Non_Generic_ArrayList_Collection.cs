using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    class student
    {
        public string name;
        public int age;
    }
    internal class Non_Generic_ArrayList_Collection
    {
        static void Example1_StoreDifferentDataTypes()
        {
            ArrayList list= new ArrayList();
            list.Add(10);
            list.Add("Vaishna");
            list.Add(106);
            list.Add(1.6);
            Console.WriteLine("Example1:storing different data types");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------------------");
                
        }
        static void Example2_RemoveInsertItems()
        {
            ArrayList fruitsList= new ArrayList();
            fruitsList.Add("Apple");
            fruitsList.Add("Banana");
            fruitsList.Add("Mango");
            fruitsList.Add("Orange");
            fruitsList.Add("Watermelon");
            fruitsList.Add("Strawberry");

            fruitsList.RemoveAt(2);//remove at index
            fruitsList.Remove("Apple");//remove by value
            fruitsList.Insert(1, "Grapes");//add value index throught
            Console.WriteLine("Example2:Remove and Insert");
            foreach(var i in fruitsList)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("----------------------------------------");

     }
        static void Example3_SortingItems()
        {
            ArrayList numbers= new ArrayList() { 20,11,19,15,18,22};
            numbers.Sort();
            Console.WriteLine("Example3:Sorting number");
            foreach (var i in numbers)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("----------------------------------------");

        }
        static void Example4_SearchingElements()
        {
            ArrayList names = new ArrayList() {"Riya","Siya","Prisha","Saisha","Geeta" };
            Console.WriteLine("Example4:Searching Elements");
            if(names.Contains("Prisha"))
            {
                Console.WriteLine("This name is in our list");

            }
            else
            {
                Console.WriteLine("name not found");
            }
                Console.WriteLine("----------------------------------------");

        }
        static void Example5_CopyToArray()
        {
            Console.WriteLine("Example5:CopyArray");

            ArrayList cities = new ArrayList() { "Jaipur", "Chennai", "Solapur", "Indore", "Chennai" };
            string[] cityArray = new string[cities.Count];
            cities.CopyTo(cityArray);
            foreach (var c in cityArray) 
            {
                Console.WriteLine($"{c}");
            }
            Console.WriteLine("----------------------------------------");

        }
        static void Example6_ReverseArray()
        {
            ArrayList numbers1 = new ArrayList() { 1,2,3,4,5,6,7,8 };
            numbers1.Reverse();
            Console.WriteLine("Example6:Reverse number");
            foreach (var i in numbers1)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("----------------------------------------");

        }
        static void Example7_UsingObject()
        {
            Console.WriteLine("Example7:Using Object");

            ArrayList students = new ArrayList();
            students.Add(new student{ name = "Prisha", age = 5 });
            students.Add(new student { name = "Saisha", age = 2 });

            {
                foreach (student s1  in students)
                {
                    Console.WriteLine(s1.name+":"+s1.age);
                }
                Console.WriteLine("----------------------------------------");

            }
        }
        static void Example8_AddRange()
        {
            ArrayList list = new ArrayList();
            ArrayList range = new ArrayList() {21,22,23,24,25,26,22 };//Adds multiple items together.
            list.AddRange(range);
            Console.WriteLine("Example8:Add Range");
            foreach (var i in list)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("----------------------------------------");

            list.RemoveRange(1,2);//removes 2 items starting from  index 1
            Console.WriteLine("Example8:Remove Range");
            foreach (var i in list)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("----------------------------------------");


            list.IndexOf(24);//Returns the index of the give number.
            Console.WriteLine("Example8:IndexOf");
            Console.WriteLine("Index of 24 is:" + list.IndexOf(24));
            Console.WriteLine("----------------------------------------");

            list.LastIndexOf(22);//Returns the last index of number that If an item is present multiple times,
            Console.WriteLine("Example8:LastIndexOf");
            Console.WriteLine("Index of 22 is:" + list.LastIndexOf(22));
            Console.WriteLine("----------------------------------------");
        }
        static void Main(string[] args)

        {
            Example1_StoreDifferentDataTypes();
            Example2_RemoveInsertItems();
            Example3_SortingItems();
            Example4_SearchingElements();
            Example5_CopyToArray();
            Example6_ReverseArray();
            Example7_UsingObject();
            Example8_AddRange();
            Console.ReadLine();

        }
    }
}
