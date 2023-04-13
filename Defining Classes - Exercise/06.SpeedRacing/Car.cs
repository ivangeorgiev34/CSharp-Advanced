using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires { get; set; }
        public Car(string model, int speed, int power, int weight, string type,double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Model = model;
            Engine = new Engine { Speed = speed, Power = power };
            Cargo = new Cargo { Type = type, Weight = weight };
            Tires = new Tires[4];
            Tires[0] = new Tires { Age = tire1Age, Pressure = tire1Pressure };
            Tires[1] = new Tires { Age = tire2Age, Pressure = tire2Pressure };
            Tires[2] = new Tires { Age = tire3Age, Pressure = tire3Pressure };
            Tires[3] = new Tires { Age = tire4Age, Pressure = tire4Pressure };
        }
    }
}
