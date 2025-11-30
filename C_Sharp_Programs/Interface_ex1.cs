using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Interface_ex1
    {
        interface IPrinter
        {
                       void Print(string document,int pages);//abstract method
            void Scan(string document,string format); //abstract method
        }
        class InkjectPrinter : IPrinter
        {
            public void Print(string document, int pages)
            {
                Console.WriteLine($"Printing {pages} pages of {document} using Inkjet Printer.");
            }
            public void Scan(string document, string format)
            {
                Console.WriteLine($"Scanning {document} in {format} format using Inkjet Printer.");
            }
        }
        class LaserPrinter : IPrinter
        {
            public void Print(string document, int pages)
            {
                Console.WriteLine($"Printing {pages} pages of {document} using Laser Printer.");
            }
            public void Scan(string document, string format)
            {
                Console.WriteLine($"Scanning {document} in {format} format using Laser Printer.");
            }
        }
        static void Main(string[] args)

        {
            Console.WriteLine("------Inkjet Printer------");
            IPrinter p1 = new InkjectPrinter();
            p1.Print("MyDocument", 5);
            p1.Scan("MyDocument", "PDF");

            Console.WriteLine("------Laser Printer------");
            LaserPrinter p2 = new LaserPrinter();
            p2.Print("MyReport", 10);
            p2.Scan("MyReport", "JPEG");
            Console.ReadLine();
        }
    }
}
