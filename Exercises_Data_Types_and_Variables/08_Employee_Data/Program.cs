using System;

namespace _08_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Amanda";
            string nameL = "Jonson";
            int age = 27;
            char gender = 'f';
            long id = 8306112507;
            int number = 27563571;
            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {nameL}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {number}");
        }
    }
}
