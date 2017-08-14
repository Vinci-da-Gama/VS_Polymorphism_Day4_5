using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class S5Books: S5Products
    {
        public int ISBN { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }

        public S5Books(int _isbn, string _author, string _title)
        {
            ISBN = _isbn;
            Author = _author;
            Title = _title;
        }

        public override void Display()
        {
            Console.WriteLine(String.Format("24 ProducrId: {0} -- ISBN: {1} -- Author: {2} -- Title: {3}.", base.ProductID, ISBN, Author, Title));
        }
    }
}
