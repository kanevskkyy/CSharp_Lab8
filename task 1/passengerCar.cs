using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class passengerCar : Car
    {
        public passengerCar(double fuelAmout, double fuelConspation)
        {
            this.fuelAmout = fuelAmout;
            this.fuelConspation = fuelConspation + 0.9;
        }
    }
}
