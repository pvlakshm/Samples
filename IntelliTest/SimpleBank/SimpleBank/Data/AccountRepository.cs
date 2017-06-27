using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleBank.Domain;
using SimpleBank.Repository;

namespace SimpleBank.Data
{
    public class AccountRepository : IAccountRepository
    {
        public void CreateAccount(
            Account a)
        {
            return;
        }

        public Account GetAccount(
            int id)
        {
            return new Account();
        }

        public void UpdateAccount(
            Account a)
        {
            return;
        }
    }

}
