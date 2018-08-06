using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class FlashLightsEventArgs : EventArgs
    {
        public FlashLightsEventArgs() {}

        public delegate void FlashLightsEventHandler(object sender, FlashLightsEventArgs e);
    }
}
