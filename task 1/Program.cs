using System;
using task_1;

class Task
{
    static void Main()
    {
        Console.Write("Information of car {Car} {fuel quaantity} {litters per km} = ");
        string[] carInformation = Console.ReadLine().Split();

        PassengerCar car = new PassengerCar(double.Parse(carInformation[1]), double.Parse(carInformation[2]));

        Console.WriteLine("Information of truck {Truck} {fuel quaantity} {litters per km} = ");
        string[] truckInformation = Console.ReadLine().Split();

        Truck truck = new Truck(double.Parse(truckInformation[1]), double.Parse(truckInformation[2]));

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}