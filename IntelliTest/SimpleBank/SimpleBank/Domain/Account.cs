using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleBank.Domain
{
    public class Account
    {
        public int              Id { get; set; }                    // an a/c number
        public decimal          Balance { get; set; }               // a/c balance
        public bool             AuthorizeOverdraft { get; set; }    // is this a/c authorized for an overdraft
        public IList<Operation> Operations { get; set; }            // history of the operations performed on this account

        public Account()
        {
            Operations = new List<Operation>();
        }
    }
}
