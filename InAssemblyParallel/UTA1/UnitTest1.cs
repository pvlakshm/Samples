using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UTA1
{
    [TestClass]
    public class UTA1_C1
    {
        static bool bTestClassInitCalled = false;
        static bool bTestInitCalled = false;

        [ClassInitialize]
        public static void testclassinit(TestContext tc)
        {
            // regardless of the parallelization mode, this should be called only once
            if (bTestClassInitCalled)
            {
                throw new Exception();
            }

            bTestClassInitCalled = true;
        }

        [ClassCleanup]
        public static void testclasscleanup()
        {
            // regardless of the parallelization mode, this should be called only once
            if (!bTestClassInitCalled)
            {
                throw new Exception();
            }
        }


        public void testinit()
        {
            if (bTestClassInitCalled)
            {
                throw new Exception();
            }

            bTestInitCalled = true;
        }

        public void testleanup()
        {
            if (!bTestInitCalled)
            {
                throw new Exception();
            }

            bTestInitCalled = false; // get it ready fr the next call to testInit()
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
