using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drone.Common;

namespace Drone
{
    public class PointD
    {
        public double X { get; }
        public double Y { get; }

        private PointD() {} // Disable the default constructor.

        public PointD(double x, double y)
        {
            X = x;
            Y = y;
        }

        private static double Degrees2Radians(double degrees) => Math.PI * degrees / 180.0;

        private static double Radians2Degrees(double radians) => 180.0 * radians / Math.PI;

        private static double CleanDirection(double direction)
        {
            double _direction = direction;
            while (_direction < 0) { _direction += 360; } // remove -ve bearings to become +ve bearings of the same direction.
            return _direction % 360; // Make the bearing in the range 0 to 359 degrees;
        }

        public static double CalcX(double distance, double direction) => Math.Sin(Degrees2Radians(direction)) * distance;
        public static double CalcY(double distance, double direction) => Math.Cos(Degrees2Radians(direction)) * distance;

        private static double CalcDistanceForX(double x, double direction) => x / Math.Cos(Degrees2Radians(direction));
        private static double CalcDistanceForY(double y, double direction) => y / Math.Cos(Degrees2Radians(direction));

        public static double CalculateHypotenuse(PointD from, PointD to) => Math.Pow(Math.Pow(from.X - to.X, 2) + Math.Pow(from.Y - to.Y, 2), 0.5); // Pythagoras.

        public static double CalculateDegrees(PointD from, PointD to) => Radians2Degrees(Math.Atan((to.X - from.X) / (to.Y - from.Y)));

        public static PointD NextPoint(PointD currentPoint, PointD moveBy) => new PointD(currentPoint.X + moveBy.X, currentPoint.Y + moveBy.Y);

        public static BoundaryBreached WouldHaveBreachedBoundary(PointD upperBoundary, PointD point)
        {
            if (point.X < 0) return BoundaryBreached.Left;
            if (point.Y < 0) return BoundaryBreached.Bottom;
            if (point.X > upperBoundary.X) return BoundaryBreached.Right;
            if (point.Y > upperBoundary.Y) return BoundaryBreached.Top;
            return BoundaryBreached.No;
        }

    }
}
