using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePolymorphism {
    class Program {
        static void Main(string[] args) {
            Truck truck = new Truck(150);
            Vehicle vehicle = (Vehicle) truck;
            truck.Print();
            Console.ReadKey(true);
            truck.Horn();
            Console.ReadKey(true);
        }
    }

    abstract class Vehicle {
        // Defining data
        protected int horsepowers = 0;
        protected string color = "red";

        public Vehicle(int horsepower) {
            this.horsepowers = horsepower;
        }

        public abstract double Calc_Topspeed(int hp);

        public void Horn() {
            Console.WriteLine("honk hooonk");
        }
    }

    class Truck : Vehicle {
        // Defining data
        private int shipment = 1200;

        public Truck(int horsepower) :base(horsepower) {
            Calc_Topspeed(horsepowers);
        }

        public int GetShipment {
            get { return shipment; }
        }
        
        public override double Calc_Topspeed(int hp) {
            double topSpeed = (hp * 1.6) - (shipment/100);
            return topSpeed;
        }

        public void Print() {
            Console.WriteLine($"A {color} truck was made!\n" +
                              $"It has as much as {horsepowers}horsepower and with a shipment of {GetShipment}kg it has a top speed of {Calc_Topspeed(horsepowers)}km/h.");
        }
    }
}
