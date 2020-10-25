using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Students> student = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Students students = new Students(firstName,lastName,grade);
                student.Add(students);
            }
            student = student.OrderByDescending(x => x.Grade).ToList();

           
            Console.WriteLine(string.Join(Environment.NewLine,student));

        }
    }
    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
;
        }
    }
}
