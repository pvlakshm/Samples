using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;
            int y = 4;
            int sum = 7;
            int randSum = 8;


            int val = new AppCode.Class1().addFlaky(x, y);
            Assert.AreEqual(randSum, val);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int x = 3;
            int y = 4;
            int sum = 7;
            int randSum = 9;


            int val = new AppCode.Class1().addFlaky(x, y);
            Assert.AreEqual(randSum, val);
        }

        [DataTestMethod]
        [DataRow(2, 2, 4)]
        public void TestMethod3(int x, int y, int sum)
        {
            int val = new AppCode.Class1().add(x, y);
            Assert.AreEqual(sum, val);
        }

        [DataTestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(3, 2, 5)]
        [DataRow(4, 2, 6)]
        public void TestMethod4(int x, int y, int sum)
        {
            int val = new AppCode.Class1().add(x, y);
            Assert.AreEqual(sum, val);
        }
    }
}
