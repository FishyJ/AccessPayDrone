using System;

namespace Drone.Commands
{
    public class FlashLightsEventArgs : EventArgs
    {
        public FlashLightsEventArgs() {}

        public delegate void FlashLightsEventHandler(object sender, FlashLightsEventArgs e);
    }
}
