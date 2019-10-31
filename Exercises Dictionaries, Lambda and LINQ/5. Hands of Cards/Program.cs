using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardOwners = new Dictionary<string, List<string>>();
            string[] currentDeck = Console.ReadLine().Split(new char[] { ':'},
                StringSplitOptions.RemoveEmptyEntries);
            while(currentDeck[0] != "JOKER")
            {
                if(cardOwners.ContainsKey(currentDeck[0]) == false)
                cardOwners
                        .Add(currentDeck[0], currentDeck[1]
                        .Split(new char[] { ',',' ' },
                         StringSplitOptions.RemoveEmptyEntries)
                        .ToList());
                else
                {
                    cardOwners[currentDeck[0]].AddRange(currentDeck[1]
                        .Split(new char[] { ',', ' ' },
                         StringSplitOptions.RemoveEmptyEntries));
                }
                cardOwners[currentDeck[0]] = cardOwners[currentDeck[0]].Distinct().ToList();
                currentDeck = Console.ReadLine().Split(new char[] { ':'},
                StringSplitOptions.RemoveEmptyEntries);
            }
            
            foreach (var owner in cardOwners)
            {
                int sum = 0;
                foreach (var card in owner.Value)
                {
                    int sumOfCurrentCard = 1;
                    int k = 1;
                    if(card[0] == '1')
                    {
                        sumOfCurrentCard *= 10;
                        k++;
                    }
                    else if(card[0] >='2' && card[0] <= '9')
                    {
                        sumOfCurrentCard *= int.Parse(card[0].ToString());
                    }
                    else if(card[0] == 'J')
                    {
                        sumOfCurrentCard *= 11;
                    }
                    else if (card[0] == 'Q')
                    {
                        sumOfCurrentCard *= 12;
                    }
                    else if (card[0] == 'K')
                    {
                        sumOfCurrentCard *= 13;
                    }
                    else if (card[0] == 'A')
                    {
                        sumOfCurrentCard *= 14;
                    }
                    if(card[k] == 'S')
                    {
                        sumOfCurrentCard *= 4;
                    }
                    else if (card[k] == 'H')
                    {
                        sumOfCurrentCard *= 3;
                    }
                    else if (card[k] == 'D')
                    {
                        sumOfCurrentCard *= 2;
                    }
                    sum += sumOfCurrentCard;
                }
                Console.WriteLine($"{owner.Key}: {sum}");
            }
            
        }
    }
}
