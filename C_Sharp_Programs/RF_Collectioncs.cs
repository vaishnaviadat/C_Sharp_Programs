using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class RF_Collectioncs
    {
        static void printarraylist(ArrayList a1)
        {
            foreach(var i in a1)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[]args)
        {
            //Arraylist
            ArrayList a1=new ArrayList();
            a1.Add(10);
            a1.Add("vaishna");
            a1.Add(15.5);
            a1.Add('A');
            a1.Add(106);
            Console.WriteLine("-------Arraylist elements----------");
            printarraylist(a1);
            Console.WriteLine();

            Console.WriteLine("-----Arraylist elements after inserting element at index 3------");
            a1.Insert(3, "Adat");
            printarraylist(a1);
            Console.WriteLine();


            Console.ReadLine();

        }
    }

}
