using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoopingbBuinesslogic
{
   public class Class1
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string City { get; set; }
            
        public Students()
        {
            Console.WriteLine("default");
        }
        public Students(string fname,string sname)
        {
            this.FirstName = fname;
            this.LastName = sname;
            Console.WriteLine("two parametrized");
        }
        public Students(string fname, string sname, string city):this( fname,sname)
        {
            this.City = city; 
            Console.WriteLine("three parametrized");
        }

    }
}
