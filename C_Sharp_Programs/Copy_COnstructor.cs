using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Copy_COnstructor
    {
        string Name;
        int EMP_id;
        int Salary;
        public Copy_COnstructor(string name, int eMP_id, int salary)
        {
            Name = name;
            EMP_id = eMP_id;
            Salary = salary;
        }
        public Copy_COnstructor(Copy_COnstructor c)
        {
            this.Name = c.Name;
            this.EMP_id =c.EMP_id;
            this.Salary = c.Salary;
        }
        public string details()
        {
            return $"Name:{Name},EMP_id:{EMP_id},Salary:{Salary}";
        }
        static void Main(string[] args)
        {
            Copy_COnstructor c1 = new Copy_COnstructor("vaishna",106,50000);
            Console.WriteLine("Original data:"+c1.details());

            Copy_COnstructor c2 = new Copy_COnstructor(c1);
            Console.WriteLine("Copy Constructor:"+c2.details());

            Console.ReadLine();

        }
    }
}
