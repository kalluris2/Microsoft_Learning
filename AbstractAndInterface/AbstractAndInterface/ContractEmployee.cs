using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    class ContractEmployee : BaseClass
    {
       // public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int HourlyRate { get; set; }
        public int TotalHours { get; set; }

        /*public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }*/

        public override int MonthlySalary()
        {
            return this.HourlyRate * this.TotalHours;
        }
    }
}
