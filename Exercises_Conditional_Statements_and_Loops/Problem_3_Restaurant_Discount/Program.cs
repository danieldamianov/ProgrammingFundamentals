using System;

namespace Problem_3_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            if (people <= 50)
            {
                switch (package)
                {
                    case "Normal":
                        double pricePerPerson = (3000.0 / 100 * 95) / people;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        break;
                    case "Gold":
                        double pricePerPerson1 = (3250.0 / 100 * 90) / people;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson1:f2}$");
                        break;
                    case "Platinum":
                        double pricePerPerson2 = (3500.0 / 100 * 85) / people;
                        Console.WriteLine($"We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson2:f2}$");
                        break;
                }
            }
            else if (people <= 100)
            {
                switch (package)
                {
                    case "Normal":
                        double pricePerPerson = (5500.0 / 100 * 95) / people;
                        Console.WriteLine($"We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        break;
                    case "Gold":
                        double pricePerPerson1 = (5750.0 / 100 * 90) / people;
                        Console.WriteLine($"We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {pricePerPerson1:f2}$");
                        break;
                    case "Platinum":
                        double pricePerPerson2 = (6000.0 / 100 * 85) / people;
                        Console.WriteLine($"We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {pricePerPerson2:f2}$");
                        break;
                }
            }
            else if (people <= 120)
            {
                switch (package)
                {
                    case "Normal":
                        double pricePerPerson = (8000.0 / 100 * 95) / people;
                        Console.WriteLine($"We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        break;
                    case "Gold":
                        double pricePerPerson1 = (8250.0 / 100 * 90) / people;
                        Console.WriteLine($"We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson1:f2}$");
                        break;
                    case "Platinum":
                        double pricePerPerson2 = (8500.0 / 100 * 85) / people;
                        Console.WriteLine($"We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerPerson2:f2}$");
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
