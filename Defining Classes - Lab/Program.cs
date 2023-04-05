using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] command = Console.ReadLine().Split();
            List<Tire[]> tireList = new List<Tire[]>();
            while ($"{command[0]} {command[1]} {command[2]}" != "No more tires")
            {
                tireList.Add(new Tire[] { new Tire(int.Parse(command[0]), double.Parse(command[1])), new Tire(int.Parse(command[2]), double.Parse(command[3])), new Tire(int.Parse(command[4]), double.Parse(command[5])), new Tire(int.Parse(command[6]), double.Parse(command[7])) });
                command = Console.ReadLine().Split();
            }
            command = Console.ReadLine().Split();
            List<Engine> engineList = new List<Engine>();
            while ($"{command[0]} {command[1]}" != "Engines done")
            {
                engineList.Add(new Engine(int.Parse(command[0]), double.Parse(command[1])));
                command = Console.ReadLine().Split();
            }
            command = Console.ReadLine().Split();
            List<Car> carsList = new List<Car>();
            while ($"{command[0]} {command[1]}" != "Show special")
            {
                carsList.Add(new Car(command[0], command[1], int.Parse(command[2]), double.Parse(command[3]), double.Parse(command[4]), engineList[int.Parse(command[5])], tireList[int.Parse(command[6])]));
                command = Console.ReadLine().Split();
            }
            for (int i = 0; i < carsList.Count; i++)
            {
                if (carsList[i].Year >= 2017 && carsList[i].Engine.HorsePower > 330)
                {
                    double pressureSum = 0;
                    for (int j = 0; j < carsList[i].Tire.Length; j++)
                    {
                        pressureSum = carsList[i].Tire[j].Pressure + pressureSum;
                    }
                    if (pressureSum > 9 && pressureSum < 10)
                    {
                        carsList[i].Drive(20);
                        Console.WriteLine($"Make: {carsList[i].Make}\nModel: {carsList[i].Model}\nYear: {carsList[i].Year}\nHorsePowers: {carsList[i].Engine.HorsePower}\nFuelQuantity: {carsList[i].FuelQuantity}");
                    }
                    
                }
               

            }
        }
    }
}
