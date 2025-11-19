using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    internal class Multilevel_Inheritances
    {
        class Vehicle
        {
            public string Brand;
            public int Speed;

            public void ShowVehicle()
            {
                Console.WriteLine($"Brand:{Brand}, Speed:{Speed}");
            }
        }
        class Car : Vehicle
        {
            public int SeatingCapacity;
            public void ShowCar()
            {
                Console.WriteLine($"Capacity:{SeatingCapacity}");
            }
        }
        class SportsCar : Car
        {
            public int HorsePower;
            public void ShowSportsCar()
            {
                Console.WriteLine($"HorsePower:{HorsePower}");
            }
        }
        static void Main(string[] args)
        {
            SportsCar s = new SportsCar();
            s.Brand = "BMW";
            s.Speed = 250;
            s.SeatingCapacity = 4;
            s.ShowVehicle();
            s.ShowCar();
            s.ShowSportsCar();
            SportsCar s1 = new SportsCar();
            s1.Brand = "Thar";
            s1.Speed = 300;
            s1.SeatingCapacity = 5;
            s1.HorsePower = 700;
            s1.ShowVehicle();
            s1.ShowCar();
            s1.ShowSportsCar();
            Console.ReadLine();
        }
    }
}
