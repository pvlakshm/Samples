using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestV2TestProejct
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void Add5and6for11()
        {
            int x = 5;
            int y = 6;
            int res = 11;

            var val = new MathLib.Add().add(x, y);
            Assert.AreEqual(res, val);
        }
    }
}
