using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();

            List<AgeId> ageId = new List<AgeId>();

            while (input[0] != "End")
            {
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                AgeId orderByAge = new AgeId(name, id, age);

                ageId.Add(orderByAge);


                input = Console.ReadLine().Split(" ").ToArray();
            }
            ageId = ageId.OrderBy(x=>x.Age).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,ageId));

        }
    }
    class AgeId
    {
        public AgeId(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
