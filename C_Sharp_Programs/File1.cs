using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    
namespace C_Sharp_Programs
{
    internal class File1
    {
        static void Main(string[] args)
        {
            //------------File Exits or not-------------------
            //string path= @"C:\File\f1.txt";//verbatim string literal
            //string path1 = @"C:\File\f3.txt";//verbatim string literal

            //if (File.Exists(path1))
            //{
            //    Console.WriteLine("File Exists");
            //}
            //else
            //{
            //    Console.WriteLine("File does not Exists");
            //}
//---------------------------------------------------------------------------------------------------------------------------//
            
            //------------File Read All data from text file-------------------
            //string path = @"C:\File\f1.txt";//verbatim string literal
            string path = @"C:\File\f2.txt";//verbatim string literal
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                string data = File.ReadAllText(path);
                Console.WriteLine("-----Data from file is---------\n" + data);
            }
            else {
                Console.WriteLine("File does not Exists");
            }
            Console.ReadLine();
        }
    }
}
