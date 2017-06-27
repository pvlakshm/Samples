using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleBank.Domain;
using SimpleBank.Repository;
using SimpleBank.Data;

namespace SimpleBank
{
    class Program
    {
        static void Main(
            string[] args)
        {
            Account a1 = new Account { Id = 34, AuthorizeOverdraft = false, Balance = 34000 };
            Account a2 = new Account { Id = 35, AuthorizeOverdraft = false, Balance = 4000 };

            var a = new AccountService(new AccountRepository(), new OperationRepository());
            a.MakeTransfer(a2, a1, 1000);
            // dummy just to get this Console App project to build
        }
    }
}
