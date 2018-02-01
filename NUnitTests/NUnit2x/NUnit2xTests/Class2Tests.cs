using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit2x;

namespace NUnit2xTests
{
    class Class2Tests
    {
        [TestCase]
        public void TestSum1()
        {
            int res = new Class2().sum(5, 6);
            Assert.AreEqual(11, res);
        }
    }
}
