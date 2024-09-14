using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class PassengerCar : Car
    {
        public PassengerCar(double fuelAmout, double fuelConspation, double fuelCapicity)
        {
            this.fuelAmout = fuelAmout;
            this.fuelConspation = fuelConspation + 0.9;
            this.fuelCapacity = fuelCapicity;
        }

        public PassengerCar(double fuelAmout, double fuelConspation)
        {
            this.fuelAmout = fuelAmout;
            this.fuelConspation = fuelConspation + 0.9;
        }

        public override void driveCar(double distance)
        {

            if (fuelAmout - distance * fuelConspation > 0)
            {
                fuelAmout -= distance * fuelConspation;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else Console.WriteLine("Car need refueling");
        }
    }
}