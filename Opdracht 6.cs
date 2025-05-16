using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6
{
    public interface IRangedWeapon
    {
        public int Shoot();
    }

    public abstract class Firearm : IRangedWeapon
    {
        public int AmmunitionCapacity { get; private set; }
        public int AmmunitionDamage { get; private set; }
        private int Loaded { get; set; }

        public Firearm(int capacity, int damage)
        {
            AmmunitionCapacity = capacity;
            AmmunitionDamage = damage;
            Loaded = capacity;
        }

        public abstract void Reload();


        public int Shoot()
        {
            if (Loaded > 0)
            {
                Loaded--;
                Console.WriteLine("Ammo left: " + Loaded);
                return AmmunitionDamage;
            }
            else
            {
                Console.WriteLine("Reload");
                return 0;
            }
        }

        public class Bow : IRangedWeapon
        {
            public string Type { get; set; }
            public string LoadedArrow { get; set; }
                
            public Bow(string type)
            {
                Type = type;
                LoadedArrow = type;
                
            }
            public void LoadArrow(string type)
            {
                this.LoadedArrow = type;
                Console.WriteLine("Arrow loaded");
            }

            public void SwapArrow(string type)
            {
                LoadedArrow = type;
                Console.WriteLine("Swapped arrow from" + this.LoadedArrow +"to" + LoadedArrow);
            }   
            public int Shoot()
            {
                Console.WriteLine("Shot with " + this.LoadedArrow + "arrow");
                return 3;
            }
        }

        public class AK47 : Firearm
        {
            private int ManufacturingYear { get; set; }


            public AK47(int year) : base(20, 10) 
            {
                ManufacturingYear = year;
            }

            public int GetManufacturingYear()
            {
                return ManufacturingYear;
            }

            public override void Reload()
            {
                Loaded = AmmunitionCapacity;
                Console.WriteLine("AK47 is reloading");
            }
        }
    } 
}

    


