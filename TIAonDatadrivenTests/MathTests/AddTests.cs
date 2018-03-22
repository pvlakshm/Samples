using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;

namespace MathTests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void atmint()
        {
            int x = 2;
            int y = 3;
            int sum = 5;

            int res = new Math.Adder().add(x, y);
            Assert.AreEqual(sum, res);
        }

        [TestMethod]
        public void atmfloat()
        {
            float x = 2.0f;
            float y = 3.0f;
            float sum = 5.0f;

            float res = new Math.Adder().add(x, y);
            Assert.AreEqual(sum, res);
        }
    }
}
