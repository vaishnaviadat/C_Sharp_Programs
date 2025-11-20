using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    class device
    {
        public virtual void turnon()
        {
            Console.WriteLine("Device is turned on");
        }
    }
    class tv:device
    {
        public override void turnon() 
        { 
            Console.WriteLine("TV is turned on");
        }
    }
    class AC:device
    {
        public override void turnon()
        {
            Console.WriteLine("AC is turned on");

        }
    }
    class music_system : device
    {
        public override void turnon()
        {
            Console.WriteLine("music is on now");

        }
    }
    internal class Method_Overriding
    {
        
        static void Main(string[] args)
        {
            device d1 = new tv();
            d1.turnon();
            device d2 = new AC();
            d2.turnon();
            device d3 = new music_system();
            d3.turnon();
            Console.ReadLine();

        }
    }
}
