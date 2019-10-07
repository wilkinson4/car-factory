using System;

namespace car_factory
{
    class Car
    {
        private int _milesDriven = 0;

        public Car(int startingMiles) 
        {
            _milesDriven = startingMiles;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Description
        {
            get
            {
                return $"A {Year} {Make} {Model}";
            }
        }

        public void Accelerate()
        {
            Console.WriteLine($"The {Make} {Model} Vroom!");
        }

        public int GetAge()
        {
            DateTime date = DateTime.Now;
            int currentYear = date.Year;
            return currentYear - Year;
        }

        public int Drive(int miles)
        {   
            _milesDriven += miles;
            return _milesDriven;
        }
    }
}