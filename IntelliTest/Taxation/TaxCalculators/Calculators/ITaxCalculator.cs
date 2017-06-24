namespace TaxCalculators
{
    using Models;

    public interface ITaxCalculator
    {
        uint calculate(
            bool        IsRented,
            Location    location,
            uint        AnnualBasicSalary,
            uint        MonthlyRent,
            uint        AnnualHouseRentAllowance);
    }
}
