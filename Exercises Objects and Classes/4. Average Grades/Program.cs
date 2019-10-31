using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int numStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < numStudents; i++)
            { 
                string[] stArgs = Console.ReadLine().Split(' ');
                students.Add(new Student(stArgs[0], stArgs.Skip(1).Select(double.Parse).ToArray()));
            }
            foreach (var student in students.Where(st => st.AverageGrade>=5.00).OrderBy(st => st.Name).ThenByDescending(st => st.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade { get { return Grades.Average(); }}
        public Student(string name , double[] grades)
        {
            Name = name;
            Grades = grades;
        }
    }
}
