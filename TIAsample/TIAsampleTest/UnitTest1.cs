using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TIAsample;

namespace TIAsampleTest
{
    [TestClass]
    public class UnitTest1
    {
        Class1 target = new Class1();

        [TestMethod]
        public void GetNameTest()
        {
            string name = target.GetName();
            Assert.AreEqual("TIA", name);

        }
    }
}
