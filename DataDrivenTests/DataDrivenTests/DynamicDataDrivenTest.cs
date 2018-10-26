using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenTests
{
    [TestClass]
    public class DynamicTestDataProvider
    {
        public static IEnumerable<object[]> GetDataMethod()
        {
            yield return new object[] { 1, 2, 3 };
        }

        public static IEnumerable<object[]> GetDataProperty
        {
            get
            {
                return new[]
                {
                    new object[] { 1, 2, 3 }
                };
            }
        }
    }

    [TestClass]
    public class DynamicDataDrivenTest
    {
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
