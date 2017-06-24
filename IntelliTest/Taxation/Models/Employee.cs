namespace Models
{
    using System;

    public class Employee
    {
        private const uint      MINIMUM_MONTHLY_SALARY = 3000;

        private readonly double houseRentAllowancePercent;
        private readonly uint   monthlyBasicSalary;
        private readonly House  currentProperty;

        public Employee(
            uint    monthlySalary,
            double  hraPercent,
            House   currentProperty)
        {
            if (currentProperty == null)
            {
                throw new ArgumentNullException("currentProperty");
            }

            if (hraPercent <= 0 || 100 <= hraPercent)
            {
                throw new ArgumentException("hraPercent", "hraPercent should between between 0 and 100.");
            }

            if (monthlySalary <= MINIMUM_MONTHLY_SALARY)
            {
                throw new ArgumentException("monthlySalary", "monthlySalary is below minimum salary.");
            }

            this.monthlyBasicSalary        = monthlySalary;
            this.houseRentAllowancePercent = hraPercent;
            this.currentProperty           = currentProperty;
        }

        public void Initialize()
        {
            this.AnnualBasicSalary        = 12 * this.monthlyBasicSalary;
            this.AnnualHouseRentAllowance = (uint)(this.houseRentAllowancePercent * this.AnnualBasicSalary / 100);
        }

        public uint AnnualHouseRentAllowance {
            get;
            private set;
        }

        public uint AnnualBasicSalary {
            get;
            private set;
        }

        public House Property {
            get
            {
                return this.currentProperty;
            }
        }
    }
}
