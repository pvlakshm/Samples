using System;
using Xunit;

namespace XUnitTestProject1
{
    public class MultTests
    {
        [Fact]
        public void Mult5and5for25()
        {
            int x = 5;
            int y = 5;
            int res = 25;

            var val = new MathLib.Multiply().mult(x, y);
            Assert.Equal(res, val);
        }
    }
}
