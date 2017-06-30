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
        [Note("No external dependencies!")]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [Note("CPU intensive")]
        public void TestMethod2()
        {
        }

        [TestMethod]
        [Note("CPU intensive")]
        [Note("Memory intensive")]
        public void TestMethod3()
        {
        }
    }
}
