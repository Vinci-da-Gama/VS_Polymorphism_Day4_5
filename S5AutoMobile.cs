using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class S5AutoMobile: S5Products
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }

        public override void Display()
        {
            Console.WriteLine(String.Format("17 -- Year is: {0} -- Model: {1} -- Brand is: {2} -- ProductID: {3}.", Year, Model, Brand, ProductID));
        }
    }
}
