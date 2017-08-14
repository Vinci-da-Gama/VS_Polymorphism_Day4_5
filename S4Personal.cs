using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_5
{
    class S4Personal:S4Assets
    {
        private string PersonName { get; set; }

        public S4Personal(int _cn, string _jt, string _pn): base(_cn, _jt)
        {
            this.CodeNum = _cn;
            this.JobTitle = _jt;
            this.PersonName = _pn;
        }

        public override void Print()
        {
            Console.WriteLine(String.Format("22 -- CodeNumber: {0} -- JobTitle: {1} -- PersonalName: {2}.", CodeNum, JobTitle, PersonName));
        }
    }
}
