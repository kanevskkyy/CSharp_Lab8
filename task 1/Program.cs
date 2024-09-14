using System;
using task_1;

class Task
{
    static void Main()
    {
        Console.Write("Enter what task you want to see = ");
        int task = int.Parse(Console.ReadLine());        
        Console.Clear();
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
                Console.Write("Information of car {Car} {fuel quaantity} {litters per km} {tank capicity} = ");
                carInformation = Console.ReadLine().Split();
                if (double.Parse(carInformation[1]) > double.Parse(carInformation[3])) car = new PassengerCar(0, double.Parse(carInformation[2]), double.Parse(carInformation[3]));
                else car = new PassengerCar(double.Parse(carInformation[1]), double.Parse(carInformation[2]), double.Parse(carInformation[3]));

                Console.Write("Information of truck {Truck} {fuel quaantity} {litters per km} {tank capicity} = ");
                truckInformation = Console.ReadLine().Split();
                if (double.Parse(truckInformation[1]) > double.Parse(truckInformation[3])) truck = new Truck(0, double.Parse(truckInformation[2]), double.Parse(truckInformation[3]));
                else truck = new Truck(double.Parse(truckInformation[1]), double.Parse(truckInformation[2]), double.Parse(truckInformation[3]));

                Console.Write("Information of bus {Bus} {fuel quantity} {liters per km} {tank capacity} = ");
                string[] busInformation = Console.ReadLine().Split();
                Bus bus;
                if (double.Parse(busInformation[1]) > double.Parse(busInformation[3]))  bus = new Bus(0, double.Parse(busInformation[2]), double.Parse(busInformation[3]));
                else bus = new Bus(double.Parse(busInformation[1]), double.Parse(busInformation[2]), double.Parse(busInformation[3]));

                Console.Write("Enter amount of commands = ");
                commands = int.Parse(Console.ReadLine());

                for (int i = 0; i < commands; i++)
                {
                    Console.Write($"{i + 1} command = ");
                    string[] information = Console.ReadLine().Split();

                    bool correctInput = true;
                    if (information[0] == "refuel")
                    {
                        double fuel = double.Parse(information[2]);
                        if(fuel <= 0)
                        {
                            Console.WriteLine("Fuel must be a positive number");
                            correctInput = false;
                        }
                    }

                    if (information[0].ToLower() == "drive" && information[1].ToLower() == "car") car.driveCar(double.Parse(information[2]));
                    else if (information[0].ToLower() == "drive" && information[1].ToLower() == "truck") truck.driveCar(double.Parse(information[2]));
                    else if (information[0].ToLower() == "drive" && information[1].ToLower() == "bus")
                    {
                        bus.fuelConspation += 1.4;
                        bus.driveCar(double.Parse(information[2]));
                    }
                    else if (information[0].ToLower() == "driveempty" && information[1].ToLower() == "bus") bus.driveCar(double.Parse(information[2]));

                    if(correctInput && information[0].ToLower() == "refuel")
                    {                    
                        if (information[0].ToLower() == "refuel" && information[1].ToLower() == "car") car.addFuel(double.Parse(information[2]));
                        else if (information[0].ToLower() == "refuel" && information[1].ToLower() == "truck") truck.addFuel(double.Parse(information[2]));
                        else if (information[0].ToLower() == "refuel" && information[1].ToLower() == "bus") bus.addFuel(double.Parse(information[2]));
                    }
                }
                Line();
                Console.WriteLine($"Car : {car.fuelAmout:F2}");
                Console.WriteLine($"Truck : {truck.fuelAmout:F2}");
                Console.WriteLine($"Bus : {bus.fuelAmout:F2}");
                break;
        }


    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}