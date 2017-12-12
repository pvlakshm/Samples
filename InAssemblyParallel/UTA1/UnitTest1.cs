using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UTA1
{
    [TestClass]
    public class UTA1_C1
    {
        static bool bAlreadyCalled = false;

        [ClassInitialize]
        public static void init(TestContext tc)
        {
            // regardless of the parallelization mode, this should be called only once
            if (bAlreadyCalled)
            {
                throw new Exception();
            }

            bAlreadyCalled = true;
        }

        [ClassCleanup]
        public static void cleanup()
        {
            // regardless of the parallelization mode, this should be called only once
            if (!bAlreadyCalled)
            {
                throw new Exception();
            }
        }

        [TestMethod]
        public void UTA1_C1_TM1()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA1_C1_TM2()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA1_C1_TM3()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA1_C1_TM4()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }
    }

    [TestClass]
    public class UTA1_C2
    {
        [TestMethod]
        public void UTA1_C2_TM1()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA1_C2_TM2()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA1_C2_TM3()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA1_C2_TM4()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }
    }
}
