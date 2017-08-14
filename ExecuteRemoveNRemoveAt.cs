using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class ExecuteRemoveNRemoveAt
    {
        public static void RemoveAtNRemove(ArrayList inv)
        {
            Console.WriteLine("14 -- Remove first one -- [0].");
            S5AutoMobile RemoveAuto = (S5AutoMobile)inv[0];
            inv.Remove(RemoveAuto);

            Console.WriteLine("18 -- RemoveAt(idx)");
            int idx = inv.Count-1;
            inv.RemoveAt(idx);

            Console.WriteLine("21 -- Show elements after Delete...");
            loopItems.ShowEachObj(inv);
        }
    }
}
