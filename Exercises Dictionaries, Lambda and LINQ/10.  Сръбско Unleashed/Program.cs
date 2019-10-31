using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.__Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var venuesStatics = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)[0] != "End")
            {
                if (isCorrectInput(input) == false)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string[] splitedText = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string singer = string.Join(" ", splitedText.TakeWhile(x => x[0] != '@'));
                splitedText = splitedText.SkipWhile(x => x[0] != '@').ToArray();
                string venue = string.Join(" ", splitedText.TakeWhile(x => isNumber(x) == false));
                venue = string.Join("", venue.Skip(1));
                long priceOfTicket = long.Parse(splitedText[splitedText.Length - 2]);
                long numberOfTickets = long.Parse(splitedText[splitedText.Length - 1]);
                if (venuesStatics.ContainsKey(venue) == false)
                {
                    venuesStatics.Add(venue, new Dictionary<string, long>());
                }
                if (venuesStatics[venue].ContainsKey(singer) == false)
                {
                    venuesStatics[venue].Add(singer, 0);
                }
                venuesStatics[venue][singer] += priceOfTicket * numberOfTickets;
                input = Console.ReadLine();
            }
            foreach (var venue in venuesStatics)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
        static bool isNumber(string text)
        {
            foreach (var letter in text)
            {
                if (letter < '0' || letter > '9')
                {
                    return false;
                }
            }
            return true;
        }
        static bool isCorrectInput(string text)
        {
            string[] splitedText = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int indexOfFirstWordOfTheArena = -1;
            for (int i = 0; i < splitedText.Length; i++)
            {
                if (splitedText[i][0] == '@')
                {
                    indexOfFirstWordOfTheArena = i;
                    break;
                }
            }
            
            if (indexOfFirstWordOfTheArena == -1)
            {
                return false;
            }
            int numberOfSingerNames = 0;
            for (int i = 0; i < indexOfFirstWordOfTheArena; i++)
            {
                numberOfSingerNames++;
            }
            if (numberOfSingerNames == 0)
            {
                return false;
            }
            int numberOfArenaNames = 0;
            for (int i = indexOfFirstWordOfTheArena; i < splitedText.Length; i++)
            {
                bool help = int.TryParse(splitedText[i], out int result);
                if (help)
                {
                    break;
                }
                else
                {
                    numberOfArenaNames++;
                }
            }
            if (numberOfArenaNames == 0)
            {
                return false;
            }
            int numberOfNumberPatameters = 0;
            for (int i = splitedText.Length - 1; true; i--)
            {
                bool help = int.TryParse(splitedText[i], out int result);
                if (help)
                {
                    numberOfNumberPatameters++;
                }
                else
                {
                    break;
                }
            }
            if (numberOfNumberPatameters != 2)
            {
                return false;
            }
            return true;
        }
    }
}
