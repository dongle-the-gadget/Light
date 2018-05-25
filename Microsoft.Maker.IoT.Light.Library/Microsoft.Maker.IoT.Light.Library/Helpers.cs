using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Maker.IoT.Light.Library
{
    public sealed class Helpers
    {
        public static bool IsCapable()
        {
            return (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.IoT");
        }
    }
}
