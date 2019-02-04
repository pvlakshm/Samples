using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenTests
{
    [TestClass]
    public class InlineDataDrivenTest
    {
        // The DataRow attribute can be used to provide values inline. These values have to be constants.
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(1, 2+2, 3+2)]
        public void TestMethod1(int x, int y, int sum)
        {
            var res = x + y;
            Assert.AreEqual(sum, res);
        }
    }
}
