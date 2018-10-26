using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenTests
{
    [TestClass]
    public class InlineDataDrivenTest
    {
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        public void TestMethod1(int x, int y, int sum)
        {
            var res = x + y;
            Assert.AreEqual(sum, res);
        }
    }
}
