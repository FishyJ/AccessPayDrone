using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Interface
{
    public interface ICommands
    {
        // Management commands.
        //object ParseCommand(string instruction);
        object Start();
        object Boundary(double x, double y);
        object InitialPosition(double x, double y);
        object Restart();
        object Shutdown();

        // Action Commands.
        object ToggleLights();
        object Alert(double seconds);
        object Home();
        object Move(double seconds, double degrees);
    }
}
