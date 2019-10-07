using System;
using System.Collections.Generic;

namespace car_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> car1 = new Dictionary<string, string>(){
                {"make", "Volkswagen"},
                {"model", "Jetta"},
                {"year", "2012"},
                {"price", "8000"}
            };

            Car ford = new Car(18000);
            ford.Make = "Ford";
            ford.Model = "F350";
            ford.Year = 2017;
            ford.Price = 37000.23;

            Car mazda = new Car(250000)
            {
                Make = "Mazda",
                Model = "B2500",
                Price = 115.99,
                Year = 1999
            };

            Car nissan = new Car(5000)
            {
                Make = "Nissan",
                Model = "GTR",
                Price = 79999.99,
                Year = 2018
            };

            List<Car> garage = new List<Car>(){
                {ford},
                {mazda},
                {nissan}
            };

            foreach (Car car in garage)
            {
                car.Accelerate();
                int age = car.GetAge();
                Console.WriteLine($"Age: {age}");

                Console.WriteLine(car.Description);

                int milesDriven = car.Drive(1000);
                Console.WriteLine($"{milesDriven} miles on this car.");
            }
        }
    }
}
