using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit2x
{
    public class Class2
    {
        public int sum(int i, int j)
        {
            if (i == 0)
                return j;
            else if (j == 0)
                return i;
            else
                return i + j;
        }
    }
}
