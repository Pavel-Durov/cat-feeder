using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Gpio;

namespace CatFeedeer.Core.Services
{
    /// <summary>
    /// Importnt notes - Constants region defines pins interface - make sure you did connected right the pins...
    /// 
    /// </summary>
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

        GpioPin _pin;

        #region Constants

        /// <summary>
        /// In current application,the assumption id that food enguine is connected to high voltage,
        /// and contrled by realy board accordingly to defined pin
        /// </summary>
        public const int FOOD_ENGINE_PIN = 21;

        #endregion

        public void SignalOutputPin(int pinId, bool binaryState)
        {
            GpioPinValue value = binaryState ? GpioPinValue.High : GpioPinValue.Low;
            SignalOutputPin(pinId, value);
        }

        public void SignalOutputPin(int pinId, GpioPinValue value)
        {
            if (_pin == null)
            {
                _pin = _gpioController.OpenPin(pinId);
                _pin.SetDriveMode(GpioPinDriveMode.Output);
            }

            _pin.Write(value);     
        }
    }
}
