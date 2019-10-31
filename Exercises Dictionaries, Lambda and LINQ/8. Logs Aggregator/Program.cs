using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var logsAgregatorForIPs = new SortedDictionary< string,List<string> >();
            var logsAgregatorForDurations = new SortedDictionary< string,int >();
            int numberOfLogs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLogs; i++)
            {
                string[] currentLog = Console.ReadLine().Split(' ');
                if (logsAgregatorForIPs.ContainsKey(currentLog[1]) == false)
                {
                    logsAgregatorForIPs.Add(currentLog[1], new List<string>());
                }
                if (logsAgregatorForDurations.ContainsKey(currentLog[1]) == false)
                {
                    logsAgregatorForDurations.Add(currentLog[1], 0);
                }
                logsAgregatorForDurations[currentLog[1]] += int.Parse(currentLog[2]);
                logsAgregatorForIPs[currentLog[1]].Add(currentLog[0]);
            }
            foreach (var user in logsAgregatorForIPs)
            {
                Console.Write(user.Key + ": ");
                Console.Write(logsAgregatorForDurations[user.Key] + " [");
                Console.WriteLine(string.Join(", ",user.Value.OrderBy(x => x).Distinct()) + "]");
            }
        }
    }
}
