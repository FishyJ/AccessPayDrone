using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class AlertEventArgs : EventArgs
    {
        public delegate void AlertEventHandler(object sender, AlertEventArgs e);
    }
}
