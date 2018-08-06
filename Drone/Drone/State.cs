using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drone
{
    public class State
    {
        private static State _state;
        private static readonly object _padlock = new object();
        private PointD _initialLocation;
        private PointD _currentLocation;
        private PointD _boundary;
        private bool _hasBoundarySet;
        private bool _preventedBorderBreach;
        private bool _started;
        private bool _lightsOn;

        private State() {} // Hide the constructor. This needs to be a singleton. There's only one drone...

        public static State Instance
        {
            get
            {
                if (_state == null)
                {
                    lock (_padlock)
                    {
                        if (_state == null)
                        {
                            _state = new State();
                        }
                    }
                }

                return _state;
            }
        }

        private double CleanDirection(double direction)
        {
            double _direction = direction;
            while (_direction < 0) { _direction += 360; } // remove -ve bearings to become +ve bearings of the same direction.
            return _direction % 360; // Make the bearing in the range 0 to 359 degrees;
        }


    }
}
