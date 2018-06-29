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


            int val = new AppCode.Class1().add(x, y);
            Assert.AreEqual(randSum, val);
        }
    }
}
