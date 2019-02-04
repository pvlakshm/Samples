using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Globalization;

namespace DataDrivenTests
{
    public class CustomTestDataSource : Attribute, ITestDataSource
    {
        // ITestDataSource has 2 methods: GetData and GetDisplayName.
        // GetData returns the data rows.
        // GetDisplayName returns the name of the test for a data row. This name is visible in the Test Explorer or
        // in the console. Note that in our case, we compose the display name as follows:
        //     the name of the DataTestMethod,
        //     followed by '('.
        //     followed by the data values as comma separated elements,
        //     followed by ')'.
        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            return new[] {
                new object[] {1, 2, 3},
                new object[] {5, 6, 11},
            };
        }

        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data != null)
            {
                return string.Format(CultureInfo.CurrentCulture, "{0}({1})", methodInfo.Name, string.Join(",", data));
            }

            return null;
        }
    }

    [TestClass]
    public class CustomDataDrivenTest
    {
        // The custom attribute extending ITestDataSource allows you to the flexibility to provide the data
        // for driving the tests, and to control the display name.
        [DataTestMethod]
        [CustomTestDataSource]
        public void TestMethod1(int x, int y, int sum)
        {
            var res = x + y;
            Assert.AreEqual(sum, res);
        }
    }
}
