using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5.S5Solu
{
    class Fruit: Food
    {
        public int PricePerUnit { get; set; }
        
        public Fruit(int _p)
        {
            PricePerUnit = _p;
        }

        public override int CaculateTotalPrice()
        {
            return PricePerUnit * Weight;
        }
    }
}
