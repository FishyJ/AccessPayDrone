using System;

namespace Drone.Commands
{
    public class ToggleLightsEventArgs : EventArgs
    {
        public ToggleLightsEventArgs() {}

        public delegate void ToggleLightsEventHandler(object sender, ToggleLightsEventArgs e);
    }
}
