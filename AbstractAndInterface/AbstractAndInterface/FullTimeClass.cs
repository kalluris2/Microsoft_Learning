using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    class FullTimeClass : BaseClass
    {
       // public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int AnnualSalary { get; set; }

        /*public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }*/

        public override int MonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
