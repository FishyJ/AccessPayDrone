using System;

namespace Drone.Commands
{
    public class AlertEventArgs : EventArgs
    {
        public delegate void AlertEventHandler(object sender, AlertEventArgs e);
    }
}
