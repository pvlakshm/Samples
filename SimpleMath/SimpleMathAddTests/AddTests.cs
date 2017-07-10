using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath.AddTests
{
    [TestClass()]
    public class AddTests
    {
        [TestMethod()]
        public void addTest()
        {
            var i = new SimpleMath.Add().add(5, 4);
            Assert.AreEqual<int>(9, i);

            //System.Threading.Thread.Sleep(((1 * 1000) * 62) * 10); // sleep for a little over 10 mins.
        }

        [TestMethod()]
        public void addTest2()
        {
            var i = new SimpleMath.Add().add(4, 5);
            Assert.AreEqual<int>(9, i);
        }

        [TestMethod()]
        public void addTest3()
        {
            var i = new SimpleMath.Add().add(0, 0);
            Assert.AreEqual<int>(0, i);
        }
    }
}
