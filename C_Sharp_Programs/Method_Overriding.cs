using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    class device
    {
        public virtual void turnon(string name)
        {
            Console.WriteLine($"Device name is:{name}");
        }
    }
    class tv:device
    {
        public override void turnon(string name) 
        { 
            Console.WriteLine($"TV name is:{name}");
        }
    }
    class AC:device
    {
        public override void turnon(string name)
        {
            Console.WriteLine($"AC name is:{name}");

        }
    }
    class music_system : device
    {
        public override void turnon(string name)
        {
            Console.WriteLine($"music name is:{name}");

        }
    }
    internal class Method_Overriding
    {
        
        static void Main(string[] args)
        {
            device d1 = new tv();
            d1.turnon("Television");
            device d2 = new AC();
            d2.turnon("no. 1");
            device d3 = new music_system();
            d3.turnon("samsung");
            Console.ReadLine();

        }
    }
}
