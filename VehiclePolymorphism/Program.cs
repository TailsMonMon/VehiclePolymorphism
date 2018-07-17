using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePolymorphism {
    class Program {
        static void Main(string[] args) {
            Truck truck = new Truck();
            Vehicle vehicle = (Vehicle) truck;

            Console.WriteLine("=== Vehicle Creator ===");
            Console.WriteLine($"With a shipment of {truck.GetShipment}");
            Console.WriteLine($"top speed is {vehicle.Calc_Topspeed(250)}km/h");
            vehicle.Horn();
            Console.ReadKey();
        }
    }

    abstract class Vehicle {
        protected int horsepowers = 0;
        protected string color = "Red";

        public Vehicle() {
            Console.WriteLine(color);
        }

        public abstract double Calc_Topspeed(int hp);

        public void Horn() {
            Console.WriteLine("honk hooonk");
        }
    }

    class Truck : Vehicle {
        private int shipment = 1200;

        public int GetShipment {
            get { return shipment; }
        }
        
        public override double Calc_Topspeed(int hp) {
            double topSpeed = (hp * 1.6) - (shipment/100);
            return topSpeed;
        }
    }
}
