using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Gpio;

namespace Microsoft.Maker.IoT.Light.Library
{
    public sealed class LightStatus
    {
        internal GpioPin pin { get; set; }
        private bool _isOn;
        public bool isOn { get { return _isOn; } set { if (value == true) { pin.Write(GpioPinValue.Low); } else {
                    pin.Write(GpioPinValue.High);
                } _isOn = value; } }
    }
}
