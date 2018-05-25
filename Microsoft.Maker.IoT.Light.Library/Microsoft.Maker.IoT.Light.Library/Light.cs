using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Gpio;

namespace Microsoft.Maker.IoT.Light.Library
{
    public sealed class Light
    {
        public int Pin { get; set; }
        private GpioPin pin;
        public LightStatus Status { get; }
        public Light()
        {
            if(Helpers.IsCapable())
            {
                pin = (GpioController.GetDefault()).OpenPin(Pin);
                Status.pin = pin;
            }
            else
            {
                Debug.WriteLine("You need to run this app in an IoT Device to use the features in this application.");
            }
        }
    }
}
