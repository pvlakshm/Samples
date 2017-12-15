using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit3x
{
    public class Class1
    {
        public bool isEven(int i)
        {
            System.Threading.Thread.Sleep(1000 * 2);
            if (i % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
