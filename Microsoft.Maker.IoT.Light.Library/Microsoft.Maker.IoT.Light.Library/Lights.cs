using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Maker.IoT.Light.Library
{
    public enum IoTDevice
    {
        RaspberryPi,
        MinnowBoardMax,
        DragonBoard
    }
   
    public sealed class Lights
    {
        private IList<Light> lights = new List<Light>();
        public static Lights GetLights(IoTDevice deviceType)
        {
            if (Helpers.IsCapable())
            {
                Lights lights = new Lights();
                IList<int> index = new List<int>();
                if (deviceType == IoTDevice.RaspberryPi)
                {
                    for (int i = 2; i < 28; i++)
                    {
                        index.Add(i);
                    }
                    index.Add(35);
                    index.Add(47);
                }
                else if (deviceType == IoTDevice.MinnowBoardMax)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        index.Add(i);
                    }
                }
                else if (deviceType == IoTDevice.DragonBoard)
                {
                    index.Add(36);
                    index.Add(12);
                    index.Add(13);
                    index.Add(69);
                    index.Add(115);
                    index.Add(24);
                    index.Add(25);
                    index.Add(35);
                    index.Add(34);
                    index.Add(28);
                    index.Add(33);
                    index.Add(21);
                    index.Add(120);
                }
                foreach (int i in index)
                {
                    lights.lights.Add(new Light { Pin = i });
                }
                return lights;
            }
            
            else
            {
                Debug.WriteLine("You need to run this app in an IoT Device to use the features in this application.");
                return null;
            }
        }
        public Light GetLightByGpio(int gpio)
        {
            if(Helpers.IsCapable())
            {
                if(lights.Any(f=> f.Pin == gpio))
                {
                    return lights.FirstOrDefault(f => f.Pin == gpio);
                }
                else
                {
                    Debug.WriteLine("No GPIO pin matches the number you match.");
                    return null;
                }
            }
            else
            {
                Debug.WriteLine("You need to run this app in an IoT Device to use the features in this application.");
                return null;
            }
        }
    }
}
