using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5.S5Solu
{
    class Execute_S5solu
    {
        public void ExecS5solu()
        {
            List<Food> FoodList = new List<Food>();
            Fruit f0 = new Fruit(2);
            f0.Weight = 10;
            f0.ProductName = "FireDragon_Fruit";

            Vege v0 = new Vege();
            v0.ProductName = "Arabian_Spinnish";
            v0.Weight = 20;
            v0.PricePerUnit = 3;
            
            Meat m0 = new Meat();
            m0.ProductName = "Kababa_Meat";
            m0.Weight = 30;
            m0.PricePerUnit = 6;

            FoodList.Add(f0);
            FoodList.Add(v0);
            FoodList.Add(m0);

            int flLen = FoodList.Count;
            int idx = 0;

            Console.WriteLine("\n35 -- Solution Result...");
            while (idx < flLen)
            {
                FoodList[idx].DisplayTotalPrice();
                idx++;
            }

        }

    }
}
