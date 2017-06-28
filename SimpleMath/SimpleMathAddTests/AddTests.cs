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
        }


        [TestMethod()]
        public void addTest2()
        {
            var i = new SimpleMath.Add().add(4, 5);
            Assert.AreEqual<int>(9, i);
        }
    }
}