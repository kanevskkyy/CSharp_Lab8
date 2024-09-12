using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Truck : Car
    {
        public Truck(double fuelAmout, double fuelConspation)
        {
            this.fuelAmout = fuelAmout * 0.95;
            this.fuelConspation = fuelConspation + 1.6;
        }
        public override void driveCar(double distance)
        {
            if (fuelAmout - distance * fuelConspation > 0)
            {
                fuelAmout -= distance * fuelConspation;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else Console.WriteLine("Truck need refueling");
        }
    }
}
