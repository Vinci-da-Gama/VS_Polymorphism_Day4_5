using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class Trunk: Auto
    {
        public int TowingCapability;
        public int CargoCapability;
        public static int RegistedNum { get; set; }

        public Trunk(string _brand, string _maker, string _color): base(_brand, _maker, _color)
        {
            this.Brand = _brand;
            this.Maker = _maker;
            this.Color = _color;
        }

        public static void DisplayTrunkRegistedNumber(){
            if (RegistedNum > 0)
            {
                Console.WriteLine("25 -- Trunk Registered Number is: "+RegistedNum+".");
            }
        }

        public void Tow()
        {
            Console.WriteLine("Tow ...");
        }

        public void Haul()
        {
            Console.WriteLine("Haul ...");
        }

        public override void Starging()
        {
            base.Starging();
            Console.WriteLine("Starging override in Thunk Class...");
        }
    }
}
