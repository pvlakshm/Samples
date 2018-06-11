using System;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class SubTests
    {
        [TestCase]
        public void Sub2from4for2()
        {
            int x = 4;
            int y = 2;
            int res = 2;

            var val = new MathLib.Subtract().sub(x, y);
            Assert.AreEqual(res, val);
        }
    }
}
