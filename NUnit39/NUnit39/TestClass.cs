using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit39
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            System.Threading.Thread.Sleep(1000 * 2);
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }

        [Test]
        public void TestMethod2()
        {
            System.Threading.Thread.Sleep(1000 * 2);
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }

        [Test]
        public void TestMethod3()
        {
            System.Threading.Thread.Sleep(1000 * 2);
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }

        [Test]
        public void TestMethod4()
        {
            System.Threading.Thread.Sleep(1000 * 2);
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
    }
}
