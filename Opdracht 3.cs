using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public interface IVehicle
    {
        public void Move();
        public void Accelerate(int speed);
    }

    public class Car : IVehicle
    {
        public string FuelType;
        public string Color;

        public Car(string fuelType, string color)
        {
            this.FuelType = fuelType;
            this.Color = color;
        }

        public void Move()
        {
            Console.WriteLine("The car is moving");  
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine("The car is speeding up to " + speed + "km/h");
        }

        public void honkHorn()
        {
            Console.WriteLine("I am a car, Honk Honk");
        }

    }

    public class Bicycle : IVehicle
    {
        public string BikeType;
        public string BikeColor;

        public Bicycle(string bikeType, string bikeColor)
        {
            this.BikeType = bikeType;
            this.BikeColor = bikeColor;
        }

        public void Move()
        {
            Console.WriteLine("The bike is moving");
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine("The bike is accelerating to " + speed + "km/h");
        }

        public void ringBell()
        {
            Console.WriteLine("I am a bicycle. Tring Tring!");
        }
    }


    public class Truck : IVehicle
    {
        public string TruckColor;
        public int TruckCapacity;

        public Truck(string truckColor, int truckCapacity)
        {
            this.TruckColor = truckColor;
            this.TruckCapacity = truckCapacity;
        }

        public void Move()
        {
            Console.WriteLine("The truck is moving, Toot Toot");
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine("The truck is speeding up to " + speed + "km/h");
        }

        public void unloadCargo()
        {
            Console.WriteLine("Succesfully unloaded cargo");
        }
    }

    public class Ebike : IVehicle
    {
        public string EbikeColor { get; set; }
        public int TopSpeed { get; set; }

        public Ebike(string ebikeColor, int topSpeed)
        {
            EbikeColor = ebikeColor;
            TopSpeed = topSpeed;
        }

        public void Move()
        {
            Console.WriteLine("The E-Bike is moving");
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine("The E-Bike is speeding up to " + speed + "km/h");
        }

        public void chargeBattery()
        {
            Console.WriteLine("The E-Bike is charging");
        }
    }
}
