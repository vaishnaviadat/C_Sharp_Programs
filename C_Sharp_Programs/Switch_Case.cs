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
            //Console.WriteLine("Enter Weekday:");
            //int week_no =int.Parse(Console.ReadLine());
            //switch(week_no)
            //{
            //    case 1:Console.WriteLine("Monday");
            //        break;
            //    case 2:Console.WriteLine("Tuesday");
            //        break;
            //    case 3:Console.WriteLine("Wednesday");
            //        break;
            //    case 4:Console.WriteLine("Friday");
            //        break;
            //    case 5:Console.WriteLine("Saturday");
            //        break;
            //    case 6:Console.WriteLine("Sunday");
            //        break;
            //   default:Console.WriteLine("Wrong Choice");
            //        break;
                
            //}
            Console.WriteLine("Enter Your Pizza(corn,vegatable,supreme)");
            string pizza=Console.ReadLine();
            switch(pizza)
            {
                case "corn":
                    Console.WriteLine("you are selecting corn");
                    break;
                case "supreme":
                    Console.WriteLine("you are selecting supreme");
                    break;
                case "vegatable":
                    Console.WriteLine("which vegatable type pizza?");
                    string vegatable=Console.ReadLine();
                    switch (vegatable)
                    {
                        case "onion":Console.WriteLine("selected onion pizza");
                            break;
                        case "capcicum":
                            Console.WriteLine("selected capcicum pizza ");
                            break;
                        case "olives":
                            Console.WriteLine("selected olives pizza");
                            break;
                        default:
                            Console.WriteLine("wrong choice");
                            break;
                    }
                    break;
                 default:Console.WriteLine("wrong choice");
                    break;
            }
            Console.ReadLine();
        }

    }
}
