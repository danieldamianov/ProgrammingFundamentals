using System;

namespace Problem_1._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabesPrice = double.Parse(Console.ReadLine());
            double robersPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            int countOfByedsabes = (int)Math.Ceiling(students + students / 10.0);
            double totalPrice = sabesPrice * countOfByedsabes + robersPrice * students + beltsPrice * (students - students / 6);
            if (totalPrice > money)
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - money):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
        }
    }
}
