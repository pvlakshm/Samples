using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsFlakyCozSUTisFalky()
        {
            // this test is flaky because the SUT is flaky.
            int x = 3;
            int y = 4;
            int sum = 7;

            int val = new AppCode.Class1().addFlaky(x, y);
            Assert.AreEqual(sum, val);
        }


        private static int state = new System.Random().Next(2);

        [TestMethod]
        public void TestIsFlakyCozEnvIsFlaky()
        {
            // this test is flaky because the environment is flaky
            Assert.AreEqual(state, 0);
        }

        private static bool parentRan = false;

        [TestMethod]
        public void parentTest_shouldAlwaysPass()
        {
            parentRan = true;
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestIsFlakyCozOfOrderOfExecution()
        {
            Assert.IsTrue(parentRan);
        }
    }
}
