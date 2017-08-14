using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Day4_5.Interfaces;

namespace Day4_5.S5InterfaceClasses
{
    class ExecuteInterfaceList
    {
        public void ShowList()
        {
            List<IPrintable> pdList = new List<IPrintable>();
            AutoCar a0 = new AutoCar();
            a0.Year = 1990;
            a0.Color = "Blue";
            a0.Brand = "Mercedes";

            Book b0 = new Book();
            b0.ISBN = 111111;
            b0.BookName = "wuha";
            b0.Author = "Author_0";

            toy t0 = new toy() { ToyID=222222, FactoryName="wuha_Factory", ToyName="toy_HUrei" };

            pdList.Add(a0);
            pdList.Add(b0);
            pdList.Add(t0);

            foreach (IPrintable item in pdList)
            {
                item.PrintOutInfo();
            }
        }
    }
}
