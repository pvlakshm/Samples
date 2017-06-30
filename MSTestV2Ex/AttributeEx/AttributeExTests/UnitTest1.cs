using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeEx;

namespace AttributeExTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [SmokeTest]
        [Note("No external dependencies!")]
        public void TestMethod1() { }

        [TestMethod]
        [Note("CPU intensive")]
        public void TestMethod2() { }

        [TestMethod]
        [Note("CPU intensive")]
        [Note("Memory intensive")]
        public void TestMethod3() { }

        // double byte:     { "啊齄", "\u554a\u9f44" },
        [TestMethod]
        [Note("啊齄")]
        public void TestMethod4() { }

        [TestMethod]
        [Note("\u554a\u9f44")]
        public void TestMethod4a() { }

        // Four byte: Ext-A { "㐀㒣", "\u3400\u34a3" },
        [TestMethod]
        [Note("㐀㒣")]
        public void TestMethod5() { }

        [TestMethod]
        [Note("\u3400\u34a3")]
        public void TestMethod5a() { }


        // Four byte: Ext-B { "𠀀𠀁","\ud840\udc00\ud840\udc01"},
        [TestMethod]
        [Note("𠀀𠀁")]
        public void TestMethod6() { }

        [TestMethod]
        [Note("\ud840\udc00\ud840\udc01")]
        public void TestMethod6a() { }
    }
}
