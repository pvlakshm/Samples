using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTests
{
    [TestClass]
    public class DatadrivenSubTests
    {
        [TestMethod]
        [DataRow(2, 2, 0)]
        [DataRow(2, 3, -1)]
        [DataRow(2, 4, -2)]
        [DataRow(2, 5, -3)]
        public void ddstmint(int x, int y, int sum)
        {
            int res = new Math.Subtractor().sub(x, y);
            Assert.AreEqual(sum, res);
        }

        [TestMethod]
        [DataRow(2.0f, 2.0f, 0.0f)]
        [DataRow(2.0f, 3.0f, -1.0f)]
        [DataRow(2.0f, 4.0f, -2.0f)]
        [DataRow(2.0f, 5.0f, -3.0f)]
        public void ddstmfloat(float x, float y, float sum)
        {
            float res = new Math.Subtractor().sub(x, y);
            Assert.AreEqual(sum, res);
        }
    }
}
