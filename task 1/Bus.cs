using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Bus : Car
    {
        public Bus(double fuelAmout, double fuelConspation, double fuelCapicity)
        {
            this.fuelAmout = fuelAmout;
            this.fuelConspation = fuelConspation;
            this.fuelCapacity = fuelCapicity;
        }
        public override void driveCar(double distance)
        {
            if (fuelAmout - distance * fuelConspation > 0)
            {
                fuelAmout -= distance * fuelConspation;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else Console.WriteLine("Bus need refueling");
        }
    }
}
