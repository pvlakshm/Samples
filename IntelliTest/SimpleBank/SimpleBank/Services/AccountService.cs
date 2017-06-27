using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SimpleBank.Repository;
using SimpleBank.Domain;

namespace SimpleBank
{
    public class AccountService
    {
        private IAccountRepository _accountRepository;
        private IOperationRepository _operationRepository;

        public AccountService(
            IAccountRepository accountRepository,
            IOperationRepository operationRepository)
        {
            _accountRepository = accountRepository;
            _operationRepository = operationRepository;
        }

        public void MakeTransfer(
            Account creditAccount,  // a/c to whcih to deposit the amount
            Account debitAccount,   // a/c from which to withdraw the amount
            decimal amount)         // the amount
        {
            if (creditAccount == null)
            {
                throw new AccountServiceException("creditAccount null");
            }

            if (debitAccount == null)
            {
                throw new AccountServiceException("debitAccount null");
            }

            if (debitAccount.Balance < amount && debitAccount.AuthorizeOverdraft == false)
            {
                throw new AccountServiceException("not enough money");
            }

            // OK, we are all set.
            // Create 2 operations to credit and debit the respective a/c's
            Operation creditOperation = new Operation() { AccountID = creditAccount.Id, Amount = amount, Direction = Direction.Deposit};
            Operation debitOperation = new Operation() { AccountID = debitAccount.Id,  Amount = amount, Direction = Direction.Withdraw };

            // add these operations to the history of operations on the respective a/c's
            creditAccount.Operations.Add(creditOperation);
            debitAccount.Operations.Add(debitOperation);

            // update the balance in the respective a/c's
            creditAccount.Balance += amount;
            debitAccount.Balance -= amount;

            // create these operations in the repository that we will access through these interfaces
            _operationRepository.CreateOperation(creditOperation);
            _operationRepository.CreateOperation(debitOperation);

            // update the account through the repository that we will access through these interfaces
            _accountRepository.UpdateAccount(creditAccount);
            _accountRepository.UpdateAccount(debitAccount);
        }

        public decimal ComputeInterest(
            Account account,
            double annualRate,
            int months)
        {
            if (account == null)
            {
                throw new AccountServiceException("Account is null");
            }

            double yearInterest = Math.Round((double)account.Balance * annualRate);
            double monthInterest = yearInterest / 12;

            return (decimal)(monthInterest * months);
        }

        public List<Operation> GetOperationsForAccount(
            int accountID)
        {
            Account account = _accountRepository.GetAccount(accountID);
            if (account == null)
            {
                return null;
            }

            if (account.Operations == null)
            {
                return null;
            }

            return account.Operations.ToList();
        }
    }
}
