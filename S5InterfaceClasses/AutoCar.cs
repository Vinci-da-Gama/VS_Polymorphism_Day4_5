using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4_5.Interfaces;

namespace Day4_5.S5InterfaceClasses
{
    class AutoCar: IPrintable, IProducts
    {
        public int Year { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

        public void PrintOutInfo()
        {
            Console.WriteLine(String.Format("18 -- Car Year: {0} -- Color: {1}, Brand: {1}.", Year, Color, Brand));
        }
    }
}
