using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleBank.Domain;

namespace SimpleBank.Repository
{
    public interface IOperationRepository
    {
        // Using the repository pattern to access the data source (whatever that source may be).
        // Separate querying of the data from the business logic.
        void CreateOperation(Operation o);
    }
}
