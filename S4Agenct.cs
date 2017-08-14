using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class S4Agenct: S4Assets
    {
        public S4Agenct(int _cn, String _jt): base(_cn, _jt)
        {
            this.CodeNum = _cn;
            this.JobTitle = _jt;
        }

        public override void Print()
        {
            Console.WriteLine(String.Format("Agent Code {0} -- Agent Job: {1}.", CodeNum, JobTitle));
        }
    }
}
