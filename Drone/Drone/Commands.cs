using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drone
{
    class Commands
    {
        private State drone;
        public Commands(State droneState)
        {
            if (droneState == null) { throw new ArgumentNullException("droneState"); }
        }

        public void StartDrone()
        {
            //if drone.
        }
    }
}
