using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTests
{
    [TestClass]
    public class DatadrivenAddTests
    {
        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(2, 3, 5)]
        [DataRow(2, 4, 6)]
        [DataRow(2, 5, 7)]
        public void dd_atm_int(int x, int y, int sum)
        {
            int res = new Math.Adder().add(x, y);
            Assert.AreEqual(sum, res);
        }

        [TestMethod]
        [DataRow(2.0f, 2.0f, 4.0f)]
        [DataRow(2.0f, 3.0f, 5.0f)]
        [DataRow(2.0f, 4.0f, 6.0f)]
        [DataRow(2.0f, 5.0f, 7.0f)]
        public void dd_atm_float(float x, float y, float sum)
        {
            float res = new Math.Adder().add(x, y);
            Assert.AreEqual(sum, res);
        }
    }
}
