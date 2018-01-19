using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AttributeEx
{
    // -------------------------------------------------------------------------------------------
    // A strongly typed attribute that allows categorizing a testmethod as a so called SmokeTest.
    // E.g.
    // [TestMethod]
    // [SmokeTest]
    // public void myTestCase() { }
    // -------------------------------------------------------------------------------------------
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class SmokeTestAttribute : TestPropertyAttribute
    {
        public SmokeTestAttribute()
            : base("SmokeTest", null)
        {
        }
    }
}
