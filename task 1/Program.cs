using System;
using task_1;

class Task
{
    static void Main()
    {
        Console.Write("Enter what task you want to see = ");
        int task = int.Parse(Console.ReadLine());
        switch (task)
        {
            case 1:
                Console.Write("Information of car {Car} {fuel quaantity} {litters per km} = ");
                string[] carInformation = Console.ReadLine().Split();
                PassengerCar car = new PassengerCar(double.Parse(carInformation[1]), double.Parse(carInformation[2]));

                Console.Write("Information of truck {Truck} {fuel quaantity} {litters per km} = ");
                string[] truckInformation = Console.ReadLine().Split();
                Truck truck = new Truck(double.Parse(truckInformation[1]), double.Parse(truckInformation[2]));

                Line();
                Console.Write("Enter amount of commands = ");
                int commands = int.Parse(Console.ReadLine());

                for (int i = 0; i < commands; i++)
                {
                    Console.Write($"{i + 1} command = ");
                    string[] information = Console.ReadLine().Split();
                    if (information[0].ToLower() == "drive" && information[1].ToLower() == "car") car.driveCar(double.Parse(information[2]));
                    else if (information[0].ToLower() == "drive" && information[1].ToLower() == "truck") truck.driveCar(double.Parse(information[2]));
                    else if (information[0].ToLower() == "refuel" && information[1].ToLower() == "car") car.addFuel(double.Parse(information[2]));
                    else if (information[0].ToLower() == "refuel" && information[1].ToLower() == "truck") truck.addFuel(double.Parse(information[2]));
                    else Console.WriteLine("Unknown command!");
                }
                Line();
                Console.WriteLine($"Car : {car.fuelAmout:F2}");
                Console.WriteLine($"Truck : {truck.fuelAmout:F2}");
                break;

            case 2:


                break;
        }


    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}