using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace _8._Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new SortedDictionary<string, Student>();
            string currentEntry = Console.ReadLine();
            while(currentEntry != "end of dates")
            {
                string[] currentEntryArgs = currentEntry.Split(new char[] { ' ', ',' });
                if(students.ContainsKey(currentEntryArgs[0]) == false)
                {
                    students.Add(currentEntryArgs[0], new Student());
                }
                for (int i = 1; i < currentEntryArgs.Length; i++)
                {
                    students[currentEntryArgs[0]].dates.Add(
                        DateTime.ParseExact(currentEntryArgs[i],"dd/MM/yyyy",CultureInfo.InvariantCulture));
                }
                currentEntry = Console.ReadLine();
            }
            currentEntry = Console.ReadLine();
            while(currentEntry != "end of comments")
            {
                string[] currentEntryArgs = currentEntry.Split(new char[] { '-' });
                if(students.ContainsKey(currentEntryArgs[0]) == false)
                {
                    currentEntry = Console.ReadLine();
                    continue;
                }
                students[currentEntryArgs[0]].comments.Add(currentEntryArgs[1]);
                currentEntry = Console.ReadLine();
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.comments)
                {
                    Console.WriteLine($" - {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.dates.OrderBy(x => x))
                {
                    Console.WriteLine($" -- {date:dd/MM/yyyy}");
                }
            }
        }
    }
    class Student
    {
        public List<DateTime> dates = new List<DateTime>();
        public List<string> comments = new List<string>();
    }
}
