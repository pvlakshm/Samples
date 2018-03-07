using System;
using System.Linq;
using Xunit;
using Mathlib;


namespace MathlibTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            int x = 5;
            int y = 6;
            int sum = 11;

            int res = new Mathlib.Class1().add(x, y);
            Assert.Equal(sum, res);
        }
    }
}
