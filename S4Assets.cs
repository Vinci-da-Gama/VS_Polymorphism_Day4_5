using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class S4Assets
    {
        public int CodeNum { get; set; }
        public string JobTitle { get; set; }

        public S4Assets(int _cn, string _jt)
        {
            this.CodeNum = _cn;
            this.JobTitle = _jt;
        }
        
        public virtual void Print()
        {
            Console.WriteLine(String.Format("CodeNum is: {0} -- JobTitle is: {1}.", CodeNum, JobTitle));
        }
    }
}
