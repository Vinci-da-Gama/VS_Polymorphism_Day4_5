using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5.S5Solu
{
    abstract class Food: IDisplayable
    {
        public int Weight { get; set; }
        public string ProductName { get; set; }

        public abstract int CaculateTotalPrice();
        public void DisplayTotalPrice()
        {
            Console.WriteLine(String.Format("17 -- Product: {0} -- TotalPrice: {1}.", ProductName, CaculateTotalPrice()));
        }
    }
}
