using OOP.Exercises;
using System;
using System.Globalization;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // MODULE 01 - TUTORIAL LABS
            var Car1 = new Car("White", 2010);           
            Car1.Mileage = 11000;

            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");

            var Car2 = new Car("Red", 2008);

            int carCount = Car.CountCars();

            Console.WriteLine($"There are {carCount} cars on inventory right now.");

            // MODULE 02 - TUTORIAL LABS
            // var employee1 = new Employee("Libby", 20000);
            var employee2 = new TechinalEmployee("Zaynah");
            var employee3 = new BussinessEmployee("Winter");

            Console.WriteLine(employee2.employeeStatus() + " . . . " + employee3.employeeStatus());

            // Operador ternário
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto =
                (preco < 20.0)
                ? preco * 0.1
                : preco * 0.05;

            /*
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            */

            Console.WriteLine(desconto);
        }
    }
}
