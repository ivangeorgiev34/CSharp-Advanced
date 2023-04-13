using System;
using System.Collections.Generic;

namespace _08.CarSalesman
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++) //engine information
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 3)
                {
                    string model = tokens[0];
                    int power = int.Parse(tokens[1]);
                    int displacement = int.Parse(tokens[2]);
                    engines.Add(new Engine(model, power, displacement));
                }
                else if (tokens.Length == 4)
                {
                    string model = tokens[0];
                    int power = int.Parse(tokens[1]);
                    int displacement = int.Parse(tokens[2]);
                    string efficiency = tokens[3];
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
                else
                {
                    string model = tokens[0];
                    int power = int.Parse(tokens[1]);
                    engines.Add(new Engine(model, power));
                }   
            }
            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 3)
                {
                    string model = tokens[0];
                    Engine engine = engines.Find(x => x.Model == tokens[1]);
                    int weight = int.Parse(tokens[2]);
                    cars.Add(new Car(model, engine, weight));
                }
                else if (tokens.Length == 4)
                {
                    string model = tokens[0];
                    Engine engine = engines.Find(x => x.Model == tokens[1]);
                    int weight = int.Parse(tokens[2]);
                    string color = tokens[3];
                    cars.Add(new Car(model, engine, weight, color));
                }
                else
                {
                    string model = tokens[0];
                    Engine engine = engines.Find(x => x.Model == tokens[1]);
                    cars.Add(new Car(model, engine));
                }
            }

            
        }
    }
}
