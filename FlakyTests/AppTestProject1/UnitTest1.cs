using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // ------------------------
        // Flaky SUT business logic
        // ------------------------
        [TestMethod]
        public void TestIsFlakyCozSUTisFalky()
        {
            // this test is flaky because the SUT business logic is flaky.
            int x = 3;
            int y = 4;
            int sum = 7;
            int val = new AppCode.Class1().addFlaky(x, y);
            Assert.AreEqual(sum, val);
        }

        // ------------------------
        // Flaky environment
        // ------------------------
        private static int state = new System.Random().Next(2); // simulate a flaky environment.

        [TestMethod]
        public void TestIsFlakyCozEnvIsFlaky()
        {
            // this test is flaky because the environment is flaky
            int val = state;
            Assert.AreEqual(val, 0);
        }


        // -----------------------------------------------------
        // Flaky due to dependence on execution order
        // This a varition of the case of the flaky environment.
        // -----------------------------------------------------
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
