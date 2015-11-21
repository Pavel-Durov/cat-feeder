using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Gpio;

namespace CatFeedeer.Core.Services
{
    class PhisicalBoardService
    {
        public PhisicalBoardService()
        {
            _gpioController = Windows.Devices.Gpio.GpioController.GetDefault();
            Init();
        }

        private void Init()
        {
           
        }

        GpioController _gpioController;

        #region ACTIVE PINS

        public const int MOTOR_PIN = 10;

        #endregion


        public void SignalPin(int pinId, GpioPinValue value, GpioPinDriveMode mode = GpioPinDriveMode.Output)
        {
            var pin = _gpioController.OpenPin(pinId);
            pin.Write(value);
            pin.SetDriveMode(mode);
        }

        ///....
    }
}
