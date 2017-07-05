using System;

namespace PathCoverage
{
    public class PathCoverage
    {
        public void ManyPaths(int a, int b)
        {
            if (a > 10)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("a");
            }

            if (b > 10)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("b");
            }
        }
    }
}
