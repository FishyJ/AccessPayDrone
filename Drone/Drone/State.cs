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
        private PointD _initialLocation;
        private PointD _currentLocation;
        private PointD _boundary;
        private bool _hasBoundarySet;
        private bool _preventedBorderBreach;
        private bool _started;
        private bool _lightsOn;
        private const float MaxSpeed = 0.5f;

        public State()
        {
            
        }

        private double Degrees2Radians(double degrees)
        {
            return Math.PI * degrees / 180.0;
        }

        public BoundaryBreached WillBoundaryBeBreached(PointD currentLocation, PointD moveBy)
        {
            PointD newLocation = new PointD(){X = currentLocation.X + moveBy.X, Y = currentLocation.Y + moveBy.Y};
            if (newLocation.X < 0) return BoundaryBreached.Left;
            if (newLocation.Y < 0) return BoundaryBreached.Bottom;
            if (newLocation.X > _boundary.X) return BoundaryBreached.Right;
            if (newLocation.Y > _boundary.Y) return BoundaryBreached.Top;
            return BoundaryBreached.No;
        }

        private double CleanDirection(double direction)
        {
            double _direction = direction;
            while (_direction < 0) { _direction += 360; } // remove -ve bearings to become +ve bearings of the same direction.
            return _direction % 360; // Make the bearing in the range 0 to 359 degrees;
        }

        private double CalcX(double distance, double direction) => Math.Sin(Degrees2Radians(direction)) * distance;
        private double CalcY(double distance, double direction) => Math.Cos(Degrees2Radians(direction)) * distance;

        private double CalcDistanceForX(double X, double direction) => X / Math.Cos(Degrees2Radians(direction));
        private double CalcDistanceForY(double Y, double direction) => Y / Math.Cos(Degrees2Radians(direction));

        public void Move(double distance, double direction)
        {
            PointD deltaPoint = new PointD();


            List<PointF> points = new List<PointF>(); // Break down the movement into 1 second 'frames', each limited to the speed of the drone.

            double _distance = distance;
            double _direction = direction;

            _direction = CleanDirection(direction);

            while (_distance >= 0)
            {
                double deltaDistance = _distance > MaxSpeed ? MaxSpeed : _distance;
                _distance -= deltaDistance;
                double _deltaX = CalcX(_distance, _direction);
                double _deltaY = CalcY(_distance, _direction);
                PointF point = new PointF();
            }

        }

        public void MoveBy(PointF moveBy)
        {
            _currentLocation.X += moveBy.X;
            _currentLocation.Y += moveBy.Y;
        }
    }
}
