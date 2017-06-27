using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath.SubTests
{
    [TestClass()]
    public class SubTests
    {
        [TestMethod()]
        public void subtractTest()
        {
            int i = new SimpleMath.Sub().subtract(5, 4);
            Assert.AreEqual<int>(1, i);
        }

        [TestMethod()]
        public void subtractTest2()
        {
            int i = new SimpleMath.Sub().subtract(50, 40);
            Assert.AreEqual<int>(10, i);
        }

        [TestMethod()]
        public void subtractTest3()
        {
            int i = new SimpleMath.Sub().subtract(500, 400);
            Assert.AreEqual<int>(100, i);
        }

        [TestMethod()]
        public void subtractTest4()
        {
            int i = new SimpleMath.Sub().subtract(5000, 4000);
            Assert.AreEqual<int>(1000, i);
        }
    }
}