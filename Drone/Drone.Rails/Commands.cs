using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drone.Interface;

namespace Drone.Rails
{
    public class Commands
    {
        public object ParseCommand(string instruction)
        {
            throw new NotImplementedException();
        }

        public object Start()
        {
            throw new NotImplementedException();
        }

        public object Boundary(double x, double y)
        {
            throw new NotImplementedException();
        }

        public object InitialPosition(double x, double y)
        {
            throw new NotImplementedException();
        }

        public object Restart()
        {
            throw new NotImplementedException();
        }

        public object Shutdown()
        {
            throw new NotImplementedException();
        }

        public object ToggleLights()
        {
            throw new NotImplementedException();
        }

        public object Alert(double seconds)
        {
            throw new NotImplementedException();
        }

        public object Home()
        {
            throw new NotImplementedException();
        }

        public object Move(double seconds, double degrees)
        {
            throw new NotImplementedException();
        }
    }
}
