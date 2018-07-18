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
            Console.WriteLine($"With a shipment of {truck.GetShipment}kg, the top speed is {vehicle.Calc_Topspeed()}km/h");
            Console.ReadKey(true);
            vehicle.Horn();
            Console.ReadKey(true);
        }
    }

    abstract class Vehicle {
        // Defining data
        protected int horsepowers = 150;
        protected string color = "red";
        protected string name = "volvo";

        public Vehicle() {
            // Not sure what to do here
        }

        public abstract double Calc_Topspeed();

        public void Horn() {
            Console.WriteLine("honk hooonk");
        }
    }

    class Truck : Vehicle {
        // Defining data
        private int shipment = 1200;

        public int GetShipment {
            get { return shipment; }
        }
        
        public override double Calc_Topspeed() {
            double topSpeed = (horsepowers * 1.6) - (shipment/100);
            return topSpeed;
        }
    }
}
