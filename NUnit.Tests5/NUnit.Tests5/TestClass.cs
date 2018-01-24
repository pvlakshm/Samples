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
            //Warn.If(true, "this is a warning");
            Assert.IsTrue(true);
        }

        [Test]
        public void TestWithMultipleAssertsAllPassing()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(5 + 5, 10);
                Assert.AreEqual(5 * 2, 10);
            });
        }

        [Test]
        public void TestCutshortAsPass()
        {
            //Warn.If(true, "this is a warning");
            Assert.Pass();
        }


        [Test]
        public void TestFail()
        {
            //Warn.If(true, "this is a warning");
            Assert.Fail();
        }

        [Test]
        public void TestWithMultipleAssertsOneFailing()
        {
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
            //Warn.If(true, "this is a warning");
            Assert.Inconclusive();
        }

        [Test]
        public void TestIgnore()
        {
            //Warn.If(true, "this is a warning");
            Assert.Ignore();
        }

        [Test]
        public void TestWarning()
        {
            Assert.Warn("this is a warning");
        }
    }
}
