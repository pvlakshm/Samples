using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank.Domain
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime _BirthDate;
        public DateTime BirthDate
        {
            get { return this._BirthDate; }
            set
            {
                this._BirthDate = value;
                this.Age = differenceInYears(_BirthDate, DateTime.Now);
            }
        }
        private DateTime _StartDateContract;
        public DateTime StartDateContract
        {
            get { return _StartDateContract; }
            set
            {
                _StartDateContract = value;
                this.ServiceYears = differenceInYears(_StartDateContract, DateTime.Now);
            }
        }
        public int Salary { get; set; }
        public Contract TypeContract { get; set; }
        public int Age { get; set; }
        public int ServiceYears { get; set; }
        private int differenceInYears(DateTime aDate1, DateTime aDate2)
        {
            //missing checks ....
            //approximative
            int years = aDate1.Year - aDate2.Year;
            if (aDate1.Month == aDate2.Month)
            {
                if (aDate2.Day < aDate1.Day) years = years - 1;
            }
            return years;
        }
    }

    public enum Contract
    {
        FullTime = 0,
        PartTime = 1
    }
}
