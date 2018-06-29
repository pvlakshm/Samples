using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCode
{
    public class Class1
    {
        public int add(int x, int y)
        {
            int r = new System.Random().Next(3);

            int sum = x + y;
            int randSum = sum + r;

            return randSum;
        }
    }
}
