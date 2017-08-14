using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class loopItems
    {
        public static void ShowEachObj(ArrayList inventory)
        {
            foreach (object item in inventory)
            {
                S5AutoMobile eachAuto = (S5AutoMobile)item;
                eachAuto.Display();
            }
        }

        public static void ShowEachInList(List<S5Products> inv)
        {
            Console.WriteLine("23 loopItems.cs -- Now Print List: " + inv.Count);
            foreach (S5Products item in inv)
            {
                item.Display();
            }
        }
    }
}
