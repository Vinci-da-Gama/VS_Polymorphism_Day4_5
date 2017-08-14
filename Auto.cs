using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class Auto
    {
        public string Brand { get; set; }
        public string Maker { get; set; }
        public string Color { get; set; }

        public Auto(string _brand, string _maker, string _color)
        {
            this.Brand = _brand;
            this.Maker = _maker;
            this.Color = _color;
        }

        public virtual void Starging()
        {
            Console.WriteLine("Starting in Auto Class...");
        }

        public void Drive(int distabce)
        {
            Console.WriteLine(String.Format("Distance you drived is: {0}.", distabce));
        }

        public void Drive(string speed, int distabce)
        {
            System.Console.WriteLine(String.Format("The speed is: {0} -- Distabce is {1}.", speed, distabce));
        }

        public void Drive(int speed, int distabce)
        {
            System.Console.WriteLine(String.Format("The distabce is: {0} -- The speed is : {1}.", distabce, speed));
        }
    }
}
