using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCode
{
    public class Class1
    {
        public int addFlaky(int x, int y)
        {
            // Here, this business logic itself is flaky.
            //
            // compute the actual sum.
            // then genereate a random number below 1000. If that number is odd, then add 1 to the sum.
            // return the sum
            int sum = x + y;

            int r = new System.Random().Next(1000);
            r = r % 2;
            sum += r;

            return sum;
        }

        public int addStable(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
    }
}
