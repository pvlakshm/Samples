using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Win10_IoT_Core;
using Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private static LED led = new Win10_IoT_Core.LED();

        [TestMethod]
        public void TestMethodON()
        {
            // whatever be the current state, ON the LED
            led.turnON();

            // get the state of the LED pin, and assert on it.
            var bON = led.State();

            Assert.IsTrue(bON);
        }

        [TestMethod]
        public void TestMethodOFF()
        {
            // whatever be the current state, OFF the LED
            led.turnOFF();

            // get the state of the LED pin, and assert on it.
            var bON = led.State();

            Assert.IsFalse(bON);
        }
    }
}
