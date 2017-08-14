using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Day4_5.S5InterfaceClasses;
using Day4_5.S5Solu;

namespace Day4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Trunk MyTrunk = new Trunk("Trunk_Brand", "Trunk_Maker", "BlackTrunk");
            MyTrunk.Brand = "BMW";
            MyTrunk.Color = "Blue";
            MyTrunk.Maker = "Maker_0";
            MyTrunk.TowingCapability = 100;
            MyTrunk.CargoCapability = 90;
            MyTrunk.Tow();
            MyTrunk.Haul();
            MyTrunk.Starging();

            int RealSpeed0 = 200;
            int CurrDistabce0 = 50000;
            MyTrunk.Drive(RealSpeed0, CurrDistabce0);

            Auto OneAuto = new Auto("Brand_0", "BMW", "Blue");

            Console.WriteLine("Overloading Funciton are relied on Qty of Arguments and Type of Arguments.");

            string RealSpeed = "100";
            int CurrDistabce = 30000;
            OneAuto.Drive(RealSpeed, CurrDistabce);
            Console.WriteLine(String.Format("35 -- Maker of Auto is: {0}.", OneAuto.Maker));

            Console.WriteLine("37 -- example of static prop and method.");
            Trunk.RegistedNum = 001;
            Trunk.DisplayTrunkRegistedNumber();

            S4Personal Personal = new S4Personal(09, "Greate_Spy", "WuhaName");
            S4PrintInfo.PrintInfo(Personal);
            Personal.Print();

            S4Agenct Agent = new S4Agenct(10, "Spy_007");
            S4PrintInfo.PrintInfo(Agent);

            Console.WriteLine("48 -- Day5_Practice");

            ArrayList inventory0 = new ArrayList();
            S5AutoMobile Auto0 = new S5AutoMobile();
            Auto0.Year = 1800;
            Auto0.Model = "Model_0";
            Auto0.Brand = "BMW";
            S5AutoMobile Auto1 = new S5AutoMobile();
            Auto1.Year = 1801;
            Auto1.Model = "Model_1";
            Auto1.Brand = "Mercedes";

            inventory0.Add(Auto0);
            inventory0.Add(Auto1);

            loopItems.ShowEachObj(inventory0);

            S5AutoMobile PromoAuto = (S5AutoMobile)inventory0[0];
            Console.WriteLine("66 -- This one is Promiton Atuo.");
            PromoAuto.Display();

            Console.WriteLine("69 -- insert one new, and check result.");
            S5AutoMobile Auto2 = new S5AutoMobile();
            Auto2.Year = 1802;
            Auto2.Model = "Model_2";
            Auto2.Brand = "BMWW";
            inventory0.Insert(1, Auto2);

            loopItems.ShowEachObj(inventory0);

            ExecuteRemoveNRemoveAt.RemoveAtNRemove(inventory0);

            List<S5Products> inventory1 = new List<S5Products>();

            S5AutoMobile a0 = new S5AutoMobile();
            a0.ProductID = 1;
            a0.Year = 1900;
            a0.Model = "Model_2nd_0";
            a0.Brand = "Mercedes";
            S5Books b0 = new S5Books(111111, "Author0", "Title0");
            b0.ProductID = 2;

            inventory1.Add(a0);
            inventory1.Add(b0);

            loopItems.ShowEachInList(inventory1);

            ExecuteInterfaceList eil = new ExecuteInterfaceList();
            eil.ShowList();

            Execute_S5solu es5s = new Execute_S5solu();
            es5s.ExecS5solu();

            Console.ReadLine();
        }
    }
}
