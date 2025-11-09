using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Switch_Case
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Weekday:");
            int week_no =int.Parse(Console.ReadLine());
            switch(week_no)
            {
                case 1:Console.WriteLine("Monday");
                    break;
                case 2:Console.WriteLine("Tuesday");
                    break;
                case 3:Console.WriteLine("Wednesday");
                    break;
                case 4:Console.WriteLine("Friday");
                    break;
                case 5:Console.WriteLine("Saturday");
                    break;
                case 6:Console.WriteLine("Sunday");
                    break;
               default:Console.WriteLine("Wrong Choice");
                    break;
                
            }
            Console.ReadLine();
        }

    }
}
