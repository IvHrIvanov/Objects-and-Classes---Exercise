using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _06.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] addVehicle = Console.ReadLine().Split(" ").ToArray();

            List<CarCatalogue> catalogue = new List<CarCatalogue>();

            while (addVehicle[0] != "End")
            {
                string type = addVehicle[0].ToLower();
                string model = addVehicle[1];
                string color = addVehicle[2];
                int horsePower = int.Parse(addVehicle[3]);

                CarCatalogue newVechicle = new CarCatalogue(type, model, color, horsePower);

                catalogue.Add(newVechicle);

                addVehicle = Console.ReadLine().Split(" ").ToArray();

            }

            string input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                CarCatalogue printCar = catalogue.First(x => x.Model == input);
                Console.WriteLine(printCar);
                input = Console.ReadLine();
            }
            List<CarCatalogue> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<CarCatalogue> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHorsePower = onlyCars.Sum(x => x.Horsepower);
            double totalTrucksHorsePower = onlyTrucks.Sum(x => x.Horsepower);

            double avrgCarsHorsePower = 0.00;
            double avrgTruckHorsePower = 0.00;

            if (onlyCars.Count > 0)
            {
                avrgCarsHorsePower = totalCarsHorsePower / onlyCars.Count;
            }
            if (onlyTrucks.Count > 0)
            {
                avrgTruckHorsePower = totalTrucksHorsePower / onlyTrucks.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {avrgCarsHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avrgTruckHorsePower:f2}.");
        }
    }

    class CarCatalogue
    {
        public CarCatalogue(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }

    }
}