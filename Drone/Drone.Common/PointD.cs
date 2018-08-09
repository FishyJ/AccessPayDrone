using System;
using System.CodeDom;
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

        public static double Degrees2Radians(double degrees) => Math.PI * degrees / 180.0;

        public static double Radians2Degrees(double radians) => 180.0 * radians / Math.PI;

        public static double CleanDirection(double degrees)
        {
            double _degrees = degrees;
            while (_degrees < 0) { _degrees += 360; } // remove -ve bearings to become +ve bearings of the same angle of degrees.
            return _degrees % 360; // Make the bearing in the range 0 to 359 degrees;
        }

        public static double CalculateX(Move move) => Math.Sin(Degrees2Radians(move.Degrees)) * move.Distance;
        public static double CalculateY(Move move) => Math.Cos(Degrees2Radians(move.Degrees)) * move.Distance;

        private static double CalculateX(double distance, double degrees) => distance * Math.Sin(Degrees2Radians(degrees));
        private static double CalculateY(double distance, double degrees) => distance * Math.Cos(Degrees2Radians(degrees));
        public static double CalculateHypotenuse(PointD from, PointD to) => Math.Pow(Math.Pow(from.X - to.X, 2) + Math.Pow(from.Y - to.Y, 2), 0.5); // Pythagoras.
        public static double CalculateDegrees(PointD from, PointD to)
        {
            double deltaX = (to.X - @from.X); // +ve = 'East' side, -ve = 'West' side, zero = North or South.
            double deltaY = (to.Y - @from.Y); // +ve = 'North side, -v = 'South' side, zero = East or West.

            if (deltaX == 0 && deltaY == 0) { return 0;} // from and to are the same location, so degrees doesn't matter as the distance will be zero.

            if (deltaX == 0) { return deltaY > 0 ? 0 : 180; } // 'North' or 'South'.
            if (deltaY == 0) { return deltaX > 0 ? 90 : 270; } // 'East' or 'West'.

            double quadrantDegrees = Radians2Degrees(Math.Atan(Math.Abs((to.X - @from.X) / (to.Y - @from.Y)))); // Returns an angle in the 'North-East' Quadrant. See corrections below.

            if (deltaX > 0 && deltaY > 0) { return quadrantDegrees; } // 'North-East' quadrant.
            if (deltaX > 0 && deltaY < 0) { return quadrantDegrees + 90; } // 'South-East' quadrant.
            if (deltaX < 0 && deltaY < 0) { return quadrantDegrees + 180; } // 'South-West' quadrant.
            if (deltaX < 0 && deltaY > 0) { return quadrantDegrees + 270; } // 'North-West' quadrant.


            return Radians2Degrees(Math.Atan((to.X - @from.X) / (to.Y - @from.Y)));
        }

        public static PointD NextPoint(PointD currentPoint, PointD moveBy) => new PointD(currentPoint.X + moveBy.X, currentPoint.Y + moveBy.Y);
        public static PointD NextPoint(PointD currentPoint, Move move) => NextPoint(currentPoint, FromVector(move.Distance, move.Degrees));
        public static PointD NextPoint(PointD currentPoint, double distance, double degrees) => NextPoint(currentPoint, FromVector(distance,degrees));
        public static PointD FromVector(double distance, double degrees) => new PointD(CalculateX(distance, degrees), CalculateY(distance, degrees));

        public static Move Move(double x, double y) => Move(new PointD(0,0), new PointD(x,y));
        public static Move Move(PointD from, PointD to)
        {
            if (from == null) { throw new ArgumentNullException(nameof(from)); }
            if (to == null) { throw new ArgumentNullException(nameof(to)); }
            return new Move(CalculateHypotenuse(from, to), CalculateDegrees(from,to));
        }

        public static BoundaryBreach BoundaryWouldBreach(PointD upperBoundary, PointD currentLocation, Move move)
        {
            double deltaX = currentLocation.X + CalculateX(move);
            double deltaY = currentLocation.Y + CalculateY(move);

            return WouldHaveBreachedBoundary(upperBoundary, new PointD(deltaX, deltaY));
        }
        public static BoundaryBreach WouldHaveBreachedBoundary(PointD upperBoundary, PointD point)
        {
            if (point.X < 0) return BoundaryBreach.Left;
            if (point.Y < 0) return BoundaryBreach.Bottom;
            if (point.X > upperBoundary.X) return BoundaryBreach.Right;
            if (point.Y > upperBoundary.Y) return BoundaryBreach.Top;
            return BoundaryBreach.No;
        }

    }
}
