namespace TaxCalculators
{
    using System;
    using Models;

    public class HRAexemptionCalculator : ITaxCalculator
    {
        public uint calculate(
            bool        IsRented,
            Location    location,
            uint        AnnualBasicSalary,
            uint        MonthlyRent,
            uint        AnnualHouseRentAllowance)
        {
            var taxExemption = default(uint);

            if (IsRented == false)
            {
                return taxExemption;
            }

            // Calculate location based allowance
            var locationAllowance = default(uint);

            switch (location)
            {
                case Location.Metro:
                    locationAllowance = Convert.ToUInt32(Math.Ceiling(0.5 * AnnualBasicSalary));
                    break;
                case Location.NonMetro:
                    locationAllowance = Convert.ToUInt32(Math.Ceiling(0.4 * AnnualBasicSalary));
                    break;
                default:
                    throw new InvalidLocationException();
            }

            // Calculate default house rent allowance
            var defaultHRA = 12 * MonthlyRent - Convert.ToUInt32(Math.Ceiling(0.1 * AnnualBasicSalary));

            // Calculate the minimum
            taxExemption = defaultHRA;
            if (locationAllowance < defaultHRA)
            {
                taxExemption = locationAllowance;
            }

            if (AnnualHouseRentAllowance < taxExemption)
            {
                taxExemption = AnnualHouseRentAllowance;
            }

            return taxExemption;
        }
    }
}
