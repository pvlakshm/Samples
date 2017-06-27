using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleBank.Domain;

namespace SimpleBank
{
    public struct PensionContribution
    {
        public int BaseContribution { get; set; }
        public int SupplementaryContribution { get; set; }
    }

    public class EmployeeServices
    {
        public PensionContribution DeterminePensionContribution(Employee e)
        {
            int BaseContribution = 0;
            int SupplementaryContribution = 0;

            DeterminePensionContribution(e.Salary, e.Age, e.TypeContract, e.ServiceYears, out BaseContribution, out SupplementaryContribution);

            var p = new PensionContribution();
            p.BaseContribution = BaseContribution;
            p.SupplementaryContribution = SupplementaryContribution;

            return p;
        }

        public void DeterminePensionContribution(
            int         Salary,
            int         Age,
            Contract    TypeContract,
            int         ServiceYears,
            out int     BaseContribution,
            out int     SupplementaryContribution)
        {
            /*
                Salary               |        <=3000         |              >3000         |
                Age                  |    <35    |    >=35   |    <35         |    >=35   |
                Service Years        |     -     |  <5 | >=5 | <5  |    >=5   |  <5 | >=5 |
                FullTime             |  Y  |  N  |  -  |  -  |  -  |  Y  | N  |     |     |
                Base Contrib  135    |     |     |     |     |  x  |  x  | x  |  x  |  x  |
                Base Contrib   80    |  x  |  x  |  x  |  x  |     |     |    |     |     |
                Suppl. Contrib 15    |  x  |     |  x  |     |     |     |    |     |     |
                Suppl. Contrib 20    |     |     |     |     |     |     | x  |     |  x  |
                Suppl. Contrib 25    |     |     |     |  x  |     |  x  |    |     |     |
                Suppl. Contrib 30    |     |     |     |     |  x  |     |    |  x  |     |
             */

            // no pre-condition checks .....

            BaseContribution = 0;
            SupplementaryContribution = 0;

            if (Salary <= 3000)
            {
                if (Age < 35)
                {
                    if (TypeContract == Contract.FullTime)
                    {
                        BaseContribution = 80;
                        SupplementaryContribution = 15;
                    }
                    else
                    {
                        BaseContribution = 80;
                        SupplementaryContribution = 0;
                    }
                }
                else
                {
                    if (ServiceYears < 5)
                    {
                        BaseContribution = 80;
                        SupplementaryContribution = 15;
                    }
                    else
                    {
                        BaseContribution = 80;
                        SupplementaryContribution = 25;
                    }
                }
            }
            else
            {
                if (Age < 35)
                {
                    if (ServiceYears < 5)
                    {
                        BaseContribution = 135;
                        SupplementaryContribution = 30;
                    }
                    else
                    {
                        if (TypeContract == Contract.FullTime)
                        {
                            BaseContribution = 135;
                            SupplementaryContribution = 25;
                        }
                        else
                        {
                            BaseContribution = 135;
                            SupplementaryContribution = 20;
                        }
                    }
                }
                else
                {
                    if (ServiceYears < 5)
                    {
                        BaseContribution = 135;
                        SupplementaryContribution = 30;
                    }
                    else
                    {
                        BaseContribution = 135;
                        SupplementaryContribution = 20;
                    }
                }
            }
        }

        public PensionContribution DeterminePensionContribution2(Employee e)
        {
            int[] Contribution = {0, 0};

            DeterminePensionContribution2(e.Salary, e.Age, e.TypeContract, e.ServiceYears, Contribution);

            var p = new PensionContribution();
            p.BaseContribution = Contribution[0];
            p.SupplementaryContribution = Contribution[1];

            return p;
        }

        public void DeterminePensionContribution2(
        int Salary,
        int Age,
        Contract TypeContract,
        int ServiceYears,
        int [] Contribution)
        {
            /*
                Salary               |        <=3000         |              >3000         |
                Age                  |    <35    |    >=35   |    <35         |    >=35   |
                Service Years        |     -     |  <5 | >=5 | <5  |    >=5   |  <5 | >=5 |
                FullTime             |  Y  |  N  |  -  |  -  |  -  |  Y  | N  |     |     |
                Base Contrib  135    |     |     |     |     |  x  |  x  | x  |  x  |  x  |
                Base Contrib   80    |  x  |  x  |  x  |  x  |     |     |    |     |     |
                Suppl. Contrib 15    |  x  |     |  x  |     |     |     |    |     |     |
                Suppl. Contrib 20    |     |     |     |     |     |     | x  |     |  x  |
                Suppl. Contrib 25    |     |     |     |  x  |     |  x  |    |     |     |
                Suppl. Contrib 30    |     |     |     |     |  x  |     |    |  x  |     |
             */

            // no pre-condition checks .....

            Contribution[0] = 0;
            Contribution[1] = 0;

            if (Salary <= 3000)
            {
                if (Age < 35)
                {
                    if (TypeContract == Contract.FullTime)
                    {
                        Contribution[0] = 80;
                        Contribution[1] = 15;
                    }
                    else
                    {
                        Contribution[0] = 80;
                        Contribution[1] = 0;
                    }
                }
                else
                {
                    if (ServiceYears < 5)
                    {
                        Contribution[0] = 80;
                        Contribution[1] = 15;
                    }
                    else
                    {
                        Contribution[0] = 80;
                        Contribution[1] = 25;
                    }
                }
            }
            else
            {
                if (Age < 35)
                {
                    if (ServiceYears < 5)
                    {
                        Contribution[0] = 135;
                        Contribution[1] = 30;
                    }
                    else
                    {
                        if (TypeContract == Contract.FullTime)
                        {
                            Contribution[0] = 135;
                            Contribution[1] = 25;
                        }
                        else
                        {
                            Contribution[0] = 135;
                            Contribution[1] = 20;
                        }
                    }
                }
                else
                {
                    if (ServiceYears < 5)
                    {
                        Contribution[0] = 135;
                        Contribution[1] = 30;
                    }
                    else
                    {
                        Contribution[0] = 135;
                        Contribution[1] = 20;
                    }
                }
            }
        }
    }
}
