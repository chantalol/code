using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5
{
    public class Bike
    {
        public int Speed { get; private set; }
        private string Brand { get; set; }

        public Bike(string brand)
        {
            Speed = 0;
            Brand = brand;
        }
        public virtual void Pedal(int pedal)
        {
            Speed += pedal;

        }

        public virtual void Brake(int brake)
        {
            Speed -= brake;
            if (Speed < 0) {
                Speed = 0;
            }
        }


        public class Ebike : Bike
        {
            public int batterypercentage { get; private set; }

            public Ebike(string brand) : base(brand)
            {
                batterypercentage = 100;
            }
            public override void Pedal(int pedal)
            {
                base.Pedal(pedal);
                batterypercentage -= pedal;
            }

            public void Charging(int battery)
            {
                if (batterypercentage < 0)
                {
                    batterypercentage += battery;
                } else
                {
                    Console.WriteLine("Ebike is fully charged");
                }
            }
        }
    }
}

