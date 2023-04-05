using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tire) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tire = tire;
        }
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }


        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        private Tire[] tire;

        public Tire[] Tire
        {
            get { return tire; }
            set { tire = value; }
        }



        public void Drive(double distance)
        {
            if (FuelQuantity - (FuelConsumption / 100) * distance >= 0)
            {
                FuelQuantity = FuelQuantity - (FuelConsumption / 100) * distance;
                return;
            }
            Console.WriteLine($"Not enough fuel to perform the trip!");
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}";

        }
    }
}
