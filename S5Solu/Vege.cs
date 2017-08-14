using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5.S5Solu
{
    class Vege: Food
    {
        public int PricePerUnit { get; set; }

        public override int CaculateTotalPrice()
        {
            return PricePerUnit * Weight;
        }
    }
}
