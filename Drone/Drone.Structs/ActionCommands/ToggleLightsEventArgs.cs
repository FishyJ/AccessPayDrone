using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class ToggleLightsEventArgs : EventArgs
    {
        public ToggleLightsEventArgs() {}

        public delegate void ToggleLightsEventHandler(object sender, ToggleLightsEventArgs e);
    }
}
