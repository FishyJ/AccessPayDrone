using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Common
{
    public class Move
    {
        public double Distance { get; }
        public double Degrees { get; }

        private Move() {} // Hide the default constructor.

        public Move(double distance, double degrees)
        {
            Distance = distance;
            Degrees = degrees;
        }
    }
}
