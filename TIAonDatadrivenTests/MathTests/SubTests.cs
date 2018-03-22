using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;

namespace MathTests
{
    [TestClass]
    public class SubTests
    {
        [TestMethod]
        public void stm_int()
        {
            int x = 2;
            int y = 3;
            int diff = -1;

            int res = new Math.Subtractor().sub(x, y);
            Assert.AreEqual(diff, res);
        }

        [TestMethod]
        public void stm_float()
        {
            float x = 2.0f;
            float y = 3.0f;
            float diff = -1.0f;

            float res = new Math.Subtractor().sub(x, y);
            Assert.AreEqual(diff, res);
        }
    }
}
