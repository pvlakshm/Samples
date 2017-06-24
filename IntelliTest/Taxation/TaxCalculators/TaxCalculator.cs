namespace TaxCalculators
{
    using System;
    using Models;

    public class TaxCalculator
    {
        public uint CalculateExemptionForRent(
            Employee        employee,
            ITaxCalculator  ic)
        {
            // Run IntelliTest here.
            // Note that IntelliTest is able to discover, and use, a concrete
            // implementation for ITaxCalculator, is able to instantiate an
            // Employee type using publicly accessible methods, and is able to
            // set up the instance data on the type with real values that can
            // let IntelliTest generate a compact test suite with high code coverage.
            var taxExemption = ic.calculate(
                                    employee.Property.IsRented,
                                    employee.Property.Location,
                                    employee.AnnualBasicSalary,
                                    employee.Property.MonthlyRent,
                                    employee.AnnualHouseRentAllowance);

            return taxExemption;
        }
    }
}
