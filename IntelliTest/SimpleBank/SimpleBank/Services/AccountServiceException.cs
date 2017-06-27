using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleBank
{
    class AccountServiceException : Exception
    {
        public AccountServiceException(
            string message)
            : base(message)
        {
            // do nothing
        }
    }
}
