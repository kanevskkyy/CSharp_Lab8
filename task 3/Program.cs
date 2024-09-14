using System;
using task_3;

class Task
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();
        string[] enteredInformation;

        while (true)
        {
            Console.Write("Enter information = ");
            enteredInformation = Console.ReadLine().Split();
            if (enteredInformation.Length == 1 && enteredInformation[0].ToLower() == "end") break;
            string type = enteredInformation[0];
            string name = enteredInformation[1];
            double weight = double.Parse(enteredInformation[2]);
            Animal animal;

            if (type == "Owl")
            {
                double wingSize = double.Parse(enteredInformation[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == "Hen")
            {
                double wingSize = double.Parse(enteredInformation[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else if (type == "Mouse")
            {
                string livingRegion = enteredInformation[3];
                animal = new Mouse(name, weight, livingRegion);
            }
            else if (type == "Dog")
            {
                string livingRegion = enteredInformation[3];
                animal = new Dog(name, weight, livingRegion);
            }
            else if (type == "Cat")
            {
                string livingRegion = enteredInformation[3];
                string breed = enteredInformation[4];
                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                string livingRegion = enteredInformation[3];
                string breed = enteredInformation[4];
                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else
            {
                throw new ArgumentException("Invalid animal type");
            }
            animal.MakeSound();

            Console.Write("Please, give me some eat ^_^ = ");
            string[] foodData = Console.ReadLine().Split();
            string foodType = foodData[0];
            int quantity = int.Parse(foodData[1]);
            Food food;
            if (foodType == "Vegetable") food = new Vegetable(quantity);
            else if (foodType == "Fruit") food = new Fruit(quantity);
            else if (foodType == "Meat") food = new Meat(quantity); 
            else if (foodType == "Seeds") food = new Seeds(quantity);   
            else throw new ArgumentException("Invalid food type");
            
            animal.Eat(food);
            animals.Add(animal);
            Line();
        }

        Console.WriteLine("\n");
        for(int i = 0; i < animals.Count; i++)
        {
            Console.WriteLine(animals[i]);
        }
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}