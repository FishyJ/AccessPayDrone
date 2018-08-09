using System;
using Drone.Common;

namespace Drone.Freedom
{
    public class Commands : Rails.Commands
    {
        public Commands()
        {
            
        }

        private static double Degrees2Radians(double degrees) => Math.PI * degrees / 180.0;

        private static double Radians2Degrees(double radians) => 180.0 * radians / Math.PI;

        private static double CalculateX(Move move) => Math.Sin(Degrees2Radians(move.Degrees)) * move.Distance;
        private static double CalculateY(Move move) => Math.Cos(Degrees2Radians(move.Degrees)) * move.Distance;

        public new static BoundaryBreach BoundaryWouldBreach(PointD upperBoundary, PointD currentLocation, Move move)
        {
            double deltaX = currentLocation.X + CalculateX(move);
            double deltaY = currentLocation.Y + CalculateY(move);

            return WouldHaveBreachedBoundary(upperBoundary, new PointD(deltaX, deltaY));
        }
    }
}
