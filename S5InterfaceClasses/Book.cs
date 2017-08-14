using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4_5.Interfaces;

namespace Day4_5.S5InterfaceClasses
{
    class Book: IPrintable, IProducts
    {
        public int ISBN { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }

        void IPrintable.PrintOutInfo()
        {
            Console.WriteLine(String.Format("18 -- Books.cs -- ISBN: {0}, BookName: {1}, Author: {2}.", ISBN, BookName, Author));
        }
    }
}
