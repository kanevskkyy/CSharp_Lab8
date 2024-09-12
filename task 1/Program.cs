using System;
using task_1;

class Task
{
    static void Main()
    {
        Console.Write("Information of car = ");
        string[] carInformation = Console.ReadLine().Split();

        PassengerCar car = new PassengerCar(double.Parse(carInformation[1]), double.Parse(carInformation[2]));
        

    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}