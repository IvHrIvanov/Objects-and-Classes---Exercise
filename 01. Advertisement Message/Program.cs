using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            string[] phrase = { "Excellent product."
                    , "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            string[] events = { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"};

            string[] autors = { "Diana", "Petya", "Stella",
                               "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                string randomPhrase = phrase[rnd.Next(0, phrase.Length)];
                string randomEvet = phrase[rnd.Next(0, events.Length)];
                string randomAutor = phrase[rnd.Next(0, autors.Length)];
                string randomCity = phrase[rnd.Next(0, cities.Length)];

                Console.WriteLine($"{randomPhrase}{randomEvet}{randomAutor} - {randomCity}");
                
            }
        }
    }


}
