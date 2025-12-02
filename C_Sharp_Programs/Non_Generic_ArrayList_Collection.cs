using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
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
        static void Main(string[] args)

        {
            Example1_StoreDifferentDataTypes();
            Example2_RemoveInsertItems();
            Example3_SortingItems();
            Example4_SearchingElements();
            Console.ReadLine();

        }
    }
}
