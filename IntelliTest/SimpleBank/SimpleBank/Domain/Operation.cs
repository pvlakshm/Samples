using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleBank.Domain
{
    public class Operation
    {
        // an operation tranfers an amount in a particular direction
        public int          AccountID { get; set; }
        public decimal      Amount { get; set; }
        public Direction    Direction { get; set; }
    }
}
