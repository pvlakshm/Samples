using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests5
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestPass()
        {
            Console.WriteLine("Console.Writline Testname: TestPass");
            Assert.IsTrue(true);
        }

        [Test]
        public void TestWithMultipleAssertsAllPassing()
        {
            Console.WriteLine("Console.Writline Testname: TestWithMultipleAssertsAllPassing");
            Assert.Multiple(() =>
            {
                Assert.AreEqual(5 + 5, 10);
                Assert.AreEqual(5 * 2, 10);
            });
        }

        [Test]
        public void TestCutshortAsPass()
        {
            Console.WriteLine("Console.Writline Testname: TestCutshortAsPass");
            Assert.Pass();
        }


        [Test]
        public void TestFail()
        {
            Console.WriteLine("Console.Writline Testname: TestFail");
            Assert.Fail();
        }

        [Test]
        public void TestWithMultipleAssertsTwoFailing()
        {
            Console.WriteLine("Console.Writline Testname: TestWithMultipleAssertsTwoFailing");
            Assert.Multiple(() =>
            {
                Assert.AreEqual(5 + 5, 11);
                Assert.AreEqual(5 + 5, 10);
                Assert.AreEqual(5 + 5, 12);
            });
        }

        [Test]
        public void TestInconclusive()
        {
            Console.WriteLine("Console.Writline Testname: TestInconclusive");
            Assert.Inconclusive();
        }

        [Test]
        public void TestIgnore()
        {
            Console.WriteLine("Console.Writline Testname: TestIgnore");
            Assert.Ignore();
        }

        [Test]
        public void TestWarning()
        {
            Console.WriteLine("Console.Writline Testname: TestWarning");
            Assert.Warn("this is a warning");
        }
    }
}
