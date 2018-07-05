using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Test
    {
        [DataTestMethod]
        [DataRow("cherry")]
        [DataRow("banana")]
        [DataRow("Apple")]
        public virtual void TestMethod(string a)
        {
            Assert.IsTrue(true);
        }
    }

    [TestClass]
    public class MyTest : Test
    {
        [DataTestMethod]
        [DataRow("orange")]
        [DataRow("pineapple")]
        public override void TestMethod(string a)
        {
            Assert.IsTrue(true);
        }
    }
}
