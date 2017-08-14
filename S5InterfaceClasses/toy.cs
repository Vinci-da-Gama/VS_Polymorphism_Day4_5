using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Day4_5.Interfaces;

namespace Day4_5.S5InterfaceClasses
{
    class toy: IPrintable, IProducts
    {
        public int ToyID { get; set; }
        public string FactoryName { get; set; }
        public string ToyName { get; set; }

        void IPrintable.PrintOutInfo()
        {
            Console.WriteLine(String.Format("19 -- ToyID: {0} -- FactoryName: {1} -- ToyName: {2}.", ToyID, FactoryName, ToyName));
        }
    }
}
