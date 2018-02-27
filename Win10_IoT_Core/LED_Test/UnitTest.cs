using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Win10_IoT_Core;

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
            Task.Delay(3 * 1000).Wait();
            // get the state of the LED pin, and assert on it.
            var bON = led.State();

            Assert.IsTrue(bON);
        }

        [TestMethod]
        public void TestMethodBlinky()
        {
            for(int i=0; i<4; ++i)
            {
                led.turnON();
                Task.Delay(500).Wait();
                led.turnOFF();
                Task.Delay(100).Wait();
            }
            // get the state of the LED pin, and assert on it.
            var bON = led.State();

            Assert.IsFalse(bON);
        }
    }
}
