using System;
using System.Text.RegularExpressions;

namespace Problem_3___First_Album
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"\[\w[\w\s-]+\w\]";
            string lyricsPattern = @"""[\w\s]+""";
            string lengthPattern = @"(?:[0-9]{1,2}:[0-9]{2}m|[0-9]+s)";
            string input = Console.ReadLine();
            int counter = 0;
            while (input != "Rock on!")
            {
                if (Regex.IsMatch(input, namePattern) && Regex.IsMatch(input, lyricsPattern) && Regex.IsMatch(input, lengthPattern))
                {
                    counter++;
                    Console.WriteLine($"{ClearName(Regex.Match(input, namePattern).Value)} -> {ClearTime(Regex.Match(input, lengthPattern).Value)} => {ClearLyrics(Regex.Match(input, lyricsPattern).Value)}");
                }
                input = Console.ReadLine();
                if (counter == 4)
                {
                    Environment.Exit(0);
                }
            }
        }
        static string ClearLyrics(string lyrics)
        {
            lyrics = lyrics.Remove(lyrics.Length - 1).Remove(0,1);
            return lyrics;
        }
        static string ClearName(string name)
        {
            name = name.Remove(name.Length - 1).Remove(0,1);
            return name;
        }
        static string ClearTime(string time)
        {
            if (time.EndsWith('m'))
            {
                time = time.Remove(time.Length - 1);
            }
            else
            {
                string time1 = time.Remove(time.Length - 1);
                time = "";
                time += $"{int.Parse(time1) / 60:d2}";
                time += ":";
                time += $"{int.Parse(time1) % 60:d2}";
            }
            return time;
        }
    }
}
