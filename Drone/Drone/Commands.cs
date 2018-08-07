using System;

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
