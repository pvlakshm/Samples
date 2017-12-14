using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit3x;

//[assembly: Parallelizable(ParallelScope.All)]


namespace NUnit3xTests
{
    public class Class1Tests
    {
        [TestCase]
        public void TestMethod1()
        {
            bool res = new Class1().isEven(4);
            Assert.IsTrue(res);
        }


        [TestCase]
        [Category("BVT")]
        public void TestMethod2()
        {
            bool res = new Class1().isEven(5);
            Assert.IsFalse(res);
        }


        //[TestCase(100, true)]
        //[TestCase(101, false)]
        //public void TestMethod3(int val, bool res)
        //{
        //    bool b = new Class1().isEven(val);
        //    Assert.AreEqual(res, b);
        //}
    }


    public class Class1Tests2
    {
        [TestCase]
        public void TestMethod1()
        {
            bool res = new Class1().isEven(4);
            Assert.IsTrue(res);
        }


        [TestCase]
        [Category("BVT")]
        public void TestMethod2()
        {
            bool res = new Class1().isEven(5);
            Assert.IsFalse(res);
        }


        //[TestCase(100, true)]
        //[TestCase(101, false)]
        //public void TestMethod3(int val, bool res)
        //{
        //    bool b = new Class1().isEven(val);
        //    Assert.AreEqual(res, b);
        //}
    }

    public class Class2Tests
    {
        [TestCase]
        public void TestRoot2()
        {
            double d = new Class2().Root(4.0);
            Assert.AreEqual(d, 2.0);
        }

        [TestCase]
        public void TestRoot9()
        {
            double d = new Class2().Root(9.0);
            Assert.AreEqual(d, 3.0);
        }
    }
}
