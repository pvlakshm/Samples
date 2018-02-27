using System.Threading.Tasks;
using Windows.Devices.Gpio;

namespace Win10_IoT_Core
{
    public class LED
    {
        private GpioPin pin;

        public LED()
        {
            InitGPIO();
        }

        private void delay()
        {
            Task.Delay(1000).Wait();
        }

        private bool InitGPIO()
        {
            const int LED_PIN = 5;
            var gpio = GpioController.GetDefault();

            if (gpio == null)
            {
                pin = null;
                return false;
            }

            pin = gpio.OpenPin(LED_PIN);
            pin.SetDriveMode(GpioPinDriveMode.Output);
            return true;
        }

        public bool turnON()
        {
            pin.Write(GpioPinValue.Low);
            Task.Delay(3 * 1000).Wait();
            return State();
        }

        public bool turnOFF()
        {
            pin.Write(GpioPinValue.High);
            return State();
        }

        public bool State()
        {
            delay();

            var val = pin.Read();

            if (val == GpioPinValue.Low)
                return true;
            else
                return false;
        }
    }
}
