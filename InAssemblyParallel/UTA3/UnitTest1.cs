using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UTA3
{
    [TestClass]
    public class UTA3_C1
    {
        // --------------------------------------------
        // regardless of parallelization mode, classinit/cleanup should be called only once.
        // Furthermore, classinit should have been called before classcleanup.
        // we use a static boolean to check that sequence of calls, and that it was called only once.
        static bool bTestClassInitCalled = false;

        [ClassInitialize]
        public static void testclassinit(TestContext tc)
        {
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
        // --------------------------------------------


        // --------------------------------------------
        // regardless of parallelization mode, testinit/cleanup should be called before/after every test in this class.
        // Furthermore, testinit should have been called before testcleanup.
        // we use a boolean to check that sequence of calls, and that it was called only once.
        bool bTestInitCalled = false;
        [TestInitialize]
        public void testinit()
        {
            if (bTestInitCalled)
            {
                throw new Exception();
            }

            bTestInitCalled = true;
        }

        [TestCleanup]
        public void testleanup()
        {
            if (!bTestInitCalled)
            {
                throw new Exception();
            }

            bTestInitCalled = false; // get it ready fr the next call to testInit()
        }
        // --------------------------------------------

        [TestMethod]
        public void UTA3_C1_TM1()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA3_C1_TM2()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA3_C1_TM3()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA3_C1_TM4()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }
    }

    [TestClass]
    public class UTA3_C2
    {
        // --------------------------------------------
        // regardless of parallelization mode, classinit/cleanup should be called only once.
        // Furthermore, classinit should have been called before classcleanup.
        // we use a static boolean to check that sequence of calls, and that it was called only once.
        static bool bTestClassInitCalled = false;

        [ClassInitialize]
        public static void testclassinit(TestContext tc)
        {
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
        // --------------------------------------------


        // --------------------------------------------
        // regardless of parallelization mode, testinit/cleanup should be called before/after every test in this class.
        // Furthermore, testinit should have been called before testcleanup.
        // we use a boolean to check that sequence of calls, and that it was called only once.
        bool bTestInitCalled = false;
        [TestInitialize]
        public void testinit()
        {
            if (bTestInitCalled)
            {
                throw new Exception();
            }

            bTestInitCalled = true;
        }

        [TestCleanup]
        public void testleanup()
        {
            if (!bTestInitCalled)
            {
                throw new Exception();
            }

            bTestInitCalled = false; // get it ready fr the next call to testInit()
        }
        // --------------------------------------------

        [TestMethod]
        public void UTA3_C2_TM1()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA3_C2_TM2()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA3_C2_TM3()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void UTA3_C2_TM4()
        {
            new Class1().Delay(3);
            Assert.IsTrue(true);
        }
    }
}
