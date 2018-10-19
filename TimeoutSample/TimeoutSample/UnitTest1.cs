using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeoutSample
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Thread.Sleep(5000);
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Thread.Sleep(3000);
        }

        [TestInitialize]
        public void TestInit()
        {
            Thread.Sleep(1000);
        }

        // The TimeoutAttribute considers the total time of a test as made up the
        // sum of the times of TestInitialize, TestMethod, and TestCleanup.
        [TestMethod]
        [Timeout(2100)]    // if you set this to 2 secs or less, the test execution will be timed out.
        public void TestMethod1()
        {
            // empty
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Thread.Sleep(1000);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Thread.Sleep(3000);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Thread.Sleep(5000);
        }
    }
}