using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit3x
{
    public class Class2
    {
        public double Root(double i)
        {
            System.Threading.Thread.Sleep(1000 * 2);
            double d = Math.Sqrt(i);
            return d;
        }
    }
}
