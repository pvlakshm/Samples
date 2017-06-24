using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculators
{
    using DAL;
    using Models;

    public class TaxRecord
    {
        private IDAL d;
        public TaxRecord(
            IDAL id)
        {
            d = id;
        }

        public bool EmployeeHRADeductionEligible(
            Employee employee)
        {
            // Run IntelliTest here.
            // Note that IntelliTest is able to discover, and use, a concrete
            // instance of IDAL, and is able to instantiate a TaxRecord type
            // (for 'd') using publicly accessible methods.
            // The HRA method on the IDAL implementation access the FileSystem.
            // Note how IntelliTest flags that as a Testability issue.
            uint val = d.HRA(employee);

            if (val > 0)
                return true;
            else
                return false;
        }
    }
}
