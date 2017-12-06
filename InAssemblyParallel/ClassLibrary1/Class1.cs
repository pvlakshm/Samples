using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Delay(double secs)
        {
            int millisecs = (int)(1000 * secs);
            System.Threading.Thread.Sleep(millisecs);
        }
    }
}
