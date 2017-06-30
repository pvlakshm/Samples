using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeEx;

namespace AttributeExTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [SmokeTest]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }
    }
}
