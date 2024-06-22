using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoopingbBuinesslogic
{
    public class Collegestudent:Students
    {
        public Collegestudent(string fname, string sname, string city):base(fname, sname)
        {
            Console.WriteLine("parameterized of child");
        }
    }
}
