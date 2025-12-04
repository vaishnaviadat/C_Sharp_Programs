using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Non_Generic_HashTable_Collection
    {
        static void displayProducts(Hashtable ht)
        {
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"Product ID: {item.Key}, Product Name: {item.Value}");
            }
        }
        static void Main(string[] args)
        {
            Hashtable products = new Hashtable();
            products.Add(101, "Laptop");
            products.Add(102, "Smartphone");
            products.Add(103, "Tablet");
            products.Add(104, "Monitor");
            products.Add(105, "Keyboard");
            Console.WriteLine("----------Product List-----------");// hashtable display data in any order

            displayProducts(products);

            Console.WriteLine($"\n Total Products:{products.Count}");

            Console.WriteLine($"\nProducts with id 102: {products[102]}");//display value of key

            products[102] = "Phone";
            Console.WriteLine($"\nUpdated product with id 102:{products[102]}");//Updated data

            displayProducts(products);

            products[103] = "TV";
            Console.WriteLine($"\nUpdated product with id 103:{products[103]}");//Updated data
            displayProducts(products);

            Console.WriteLine("----------Product Search-----------");// search data

            if (products.ContainsKey(107))
            {
                Console.WriteLine("Product with ID 106 exists.");
            }
            else
            {
                Console.WriteLine("Product with ID 106 does not exist.");
            }
            if (products.ContainsValue("Phone"))
            {
                Console.WriteLine("Product value exists.");
            }
            else
            {
                Console.WriteLine("Product value does not exist.");
            }
            products.Remove(104);
            displayProducts(products);

            products.Clear();
            Console.WriteLine($"\n Total Products:{products.Count}");

            Console.ReadLine();
        }
    }
}
