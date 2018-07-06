using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddFlaky()
        {
            int x = 3;
            int y = 4;
            int sum = 7;

            int val = new AppCode.Class1().addFlaky(x, y);
            Assert.AreEqual(sum, val);
        }

        [TestMethod]
        public void TestAdd()
        {
            int x = 3;
            int y = 4;
            int sum = 7;

            int val = new AppCode.Class1().add(x, y);
            Assert.AreEqual(sum, val);
        }

        [DataTestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(3, 2, 5)]
        [DataRow(4, 2, 6)]
        public void DatadrivenTestAddFlaky(int x, int y, int sum)
        {
            int val = new AppCode.Class1().add(x, y);
            Assert.AreEqual(sum, val);
        }

        [DataTestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(3, 2, 5)]
        [DataRow(4, 2, 6)]
        public void DatadrivenTestAdd(int x, int y, int sum)
        {
            int val = new AppCode.Class1().add(x, y);
            Assert.AreEqual(sum, val);
        }
    }
}
