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
        [Note("External dependencies!")]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [Note("External dependencies!")]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }
    }
}
