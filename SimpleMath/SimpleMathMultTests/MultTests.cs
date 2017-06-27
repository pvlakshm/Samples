using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath.MultTests
{
    [TestClass()]
    public class MultTests
    {
        [TestMethod()]
        public void multTest()
        {
            var i = new SimpleMath.Mult().mult(5, 4);
            Assert.AreEqual<int>(20, i);
        }
    }
}