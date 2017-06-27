using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleBank.Domain;

namespace SimpleBank.Repository
{
    public interface IAccountRepository
    {
        // Using the Repository pattern to access the data source (whatever that source may be).
        // Separate querying of the data from the business logic.
        void CreateAccount(Account account);
        Account GetAccount(int id);
        void UpdateAccount(Account account);
    }
}
