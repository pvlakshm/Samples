using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AttributeEx
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class SmokeTest : TestPropertyAttribute
    {
        public SmokeTest()
            : base("SmokeTest", null)
        {
        }
    }
}
