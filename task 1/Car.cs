using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Car
    {
        double fuelAmout {  get; set; }
        double fuelConspation { get; set; }

        virtual public void addFuel(double fuel)
        {
            fuelAmout += fuel;
        }

        public void driveCar(double distance)
        {
            if(fuelAmout - distance * fuelConspation > 0)
            {
                fuelAmout -= distance * fuelConspation;
            }
        }
    }
}
