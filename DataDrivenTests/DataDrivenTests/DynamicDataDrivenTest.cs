using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenTests
{
    // this is a helper class that serves to provide the data for the data driven tests.
    public class DynamicTestDataProvider
    {
        public static IEnumerable<object[]> GetDataMethod()
        {
            yield return new object[] { 1, 2, int.Parse("3") };
        }

        public static IEnumerable<object[]> GetDataProperty
        {
            get
            {
                return new[]
                {
                    new object[] { 1, 2, int.Parse("3") }
                };
            }
        }
    }

    [TestClass]
    public class DynamicDataDrivenTest
    {
        // The DynamicData attribute can be used in the cases where the data is complex / dynamically computed.
        // The attribute allows you to get the parameter values from a method or a property
        [DataTestMethod]
        [DynamicData("GetDataMethod", typeof(DynamicTestDataProvider), DynamicDataSourceType.Method)]
        public void TestMethod1(int x, int y, int sum)
        {
            var res = x + y;
            Assert.AreEqual(sum, res);
        }

        [DataTestMethod]
        [DynamicData("GetDataProperty", typeof(DynamicTestDataProvider), DynamicDataSourceType.Property)]
        public void TestMethod2(int x, int y, int sum)
        {
            var res = x + y;
            Assert.AreEqual(sum, res);
        }
    }
}
