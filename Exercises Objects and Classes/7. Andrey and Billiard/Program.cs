using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            var products = new Dictionary<string, decimal>();
            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] currentProduct = Console.ReadLine().Split(new char[] { '-',});
                products[currentProduct[0]] = decimal.Parse(currentProduct[1]);
            }
            List<Customer> Custs = new List<Customer>();
            string[] currentClient = Console.ReadLine().Split(new char[] { '-', ','});
            while (currentClient[0] != "end of clients")
            {
                if (products.ContainsKey(currentClient[1]))
                {
                    if (Custs.Exists(x => x.Name == currentClient[0]) == false)
                    {
                        Custs.Add(new Customer(currentClient[0]));
                    }
                    int pos = Custs.FindIndex(x => x.Name == currentClient[0]);
                    if (Custs[pos].ShopList.ContainsKey(currentClient[1]) == false)
                    {
                        Custs[pos].ShopList.Add(currentClient[1], int.Parse(currentClient[2]));
                    }
                    else
                    {
                        Custs[pos].ShopList[currentClient[1]] += int.Parse(currentClient[2]);
                    }
                }
                currentClient = Console.ReadLine().Split(new char[] { '-', ',', });
            }
            foreach (var customer in Custs)
            {
                foreach (var product in customer.ShopList)
                {
                    customer.Bill += product.Value * products[product.Key];
                }
            }
            foreach (var customer in Custs.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {Custs.Sum(x => x.Bill):f2}");
        }
    }
    class Customer
    {
        public string Name;
        public Dictionary<string, int> ShopList = new Dictionary<string, int>();
        public decimal Bill = 0;
        public Customer(string name)
        {
            Name = name;
        }
    }
}
