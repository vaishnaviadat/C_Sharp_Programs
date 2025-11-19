using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Single_Level_Inhritances
    {   class Person
        {
            public int Age;
            public string Name;
            public void PersonDetails()
            {
                Console.WriteLine($"Name:{Name}, Age:{Age}");
            }
        }
        class Student : Person
        {
            public int StudentID;
            public void StudentDetails()
            {
                Console.WriteLine($"StudentID:{StudentID}");
            }
        }
        static void Main(string[] args)

        {
            Student s = new Student();
            s.Name = "Vaishna";
            s.Age = 21;
            s.StudentID = 201;
            s.PersonDetails();
            s.StudentDetails();
            Console.ReadLine();
        }
    }
}
