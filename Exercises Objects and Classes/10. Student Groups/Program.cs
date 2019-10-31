using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _10._Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    string[] townArgsInitial = input.Split(new char[] { '=', '>' }
                    , StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    string townName = townArgsInitial[0];
                    int townCapacity = int.Parse(townArgsInitial[1].Split(' ')[0]);
                    towns.Add(new Town(townName, townCapacity));
                    input = Console.ReadLine();
                    continue;
                }
                string[] studentArgs = input.Split('|').Select(z => z.Trim()).ToArray();
                string studentName = studentArgs[0];
                string studentEmail = studentArgs[1];
                DateTime studentDate = DateTime.ParseExact(studentArgs[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                towns[towns.Count - 1].Students.Add(new Student(studentName, studentEmail, studentDate));
                input = Console.ReadLine();
            }
            List<Group> groups = new List<Group>();
            foreach (Town town in towns.OrderBy(m => m.Name))
            {
                List<Student> students = town.Students.OrderBy(y => y.DateOfRegistration)
                    .ThenBy(y => y.Name).ThenBy(y => y.Email).ToList();
                while (students.Any())
                {
                    groups.Add(new Group(town.Name, students.Take(town.Capacity).ToList()));
                    students = students.Skip(town.Capacity).ToList();
                }
            }
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");//!!!!!!
            foreach (Group group in groups.OrderBy(x => x.Town))
            {
                Console.WriteLine($"{group.Town} => {string.Join(", ", group.Students.Select(x => x.Email))}");
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Student(string name , string email , DateTime date)
        {
            Name = name;
            Email = email;
            DateOfRegistration = date;
        }
    }
    class Town
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Student> Students { get; set; }
        public Town(string name , int capcity)
        {
            Name = name;
            Capacity = capcity;
            Students = new List<Student>();
        }
    }
    class Group
    {
        public string Town { get; set; }
        public List<Student> Students { get; set; }
        public Group(string town , List<Student> students)
        {
            Town = town;
            Students = students;
        }
    }
}
