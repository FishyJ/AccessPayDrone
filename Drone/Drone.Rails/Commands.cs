using System;
using Drone.Common;
using Move = Drone.Commands.Move;

namespace Drone.Rails
{
    public class Commands
    {


        public static BoundaryBreach BoundaryWouldBreach(PointD upperBoundary, PointD currentLocation, Common.Move move)
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

        public static Location NextLocation(PointD upperBoundary, Location curentLocation, PointD moveBy)
        {
            PointD nextPoint = PointD.NextPoint(curentLocation.Point, moveBy);
            return new Location(nextPoint, WouldHaveBreachedBoundary(upperBoundary, nextPoint));
        }

        public static double CalculateX(Drone.Common.Move move) => Math.Sin(Degrees2Radians(move.Degrees)) * move.Distance;
        public static double CalculateY(Drone.Common.Move move) => Math.Cos(Degrees2Radians(move.Degrees)) * move.Distance;

        public static double Degrees2Radians(double degrees) => Math.PI * degrees / 180.0;

        public static double Radians2Degrees(double radians) => 180.0 * radians / Math.PI;

    }
}
