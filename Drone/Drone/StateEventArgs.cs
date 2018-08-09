using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drone.Commands;

namespace Drone
{
    public class StateEventArgs : EventArgs
    {
        public BaseCommand Command { get; set; }
        public string Message { get; set; }
        public delegate void StateEventHandler(object sender, StateEventArgs e);
    }
}
