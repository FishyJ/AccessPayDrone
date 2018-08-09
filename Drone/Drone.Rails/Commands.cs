using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Drone.Commands;
using Drone.Common;
using Move = Drone.Commands.Move;

namespace Drone.Rails
{
    public class Commands
    {
        private static bool ValidAngleForRails(Common.Move move)
        {
            switch (move.Degrees)
            {
                case 0:
                case 90:
                case 180:
                case 270:
                    return true;
                default:
                    return false;
            }
        }

        private static double CalculateX(Common.Move move)
        {
            double degrees = move.Degrees;
            double distance = move.Distance;

            if (ValidAngleForRails(move))
            {
                switch (degrees)
                {
                    case 90:
                        return distance;
                    case 270:
                        return distance * -1;
                    default:
                        return 0;
                }
            }
            else
            {
                throw new InvalidCommandException($"An angle of {degrees} is not valid for the Rails module.");
            }
        }
        private static double CalculateY(Common.Move move)
        {
            double degrees = move.Degrees;
            double distance = move.Distance;

            if (ValidAngleForRails(move))
            {
                switch (degrees)
                {
                    case 0:
                        return distance;
                    case 180:
                        return distance * -1;
                    default:
                        return 0;
                }
            }
            else
            {
                throw new InvalidCommandException($"An angle of {degrees} is not valid for the Rails module.");
            }
        }

        //protected static Common.Move MoveCommonToCommands(Drone.Commands.Move move) => new Common.Move(move.Time * Drone.Common.Constants.MaxSpeed, move.Direction);
        //protected static Drone.Commands.Move MoveCommandstoCommon(Common.Move move) => new Drone.Commands.Move(move.Distance / Drone.Common.Constants.MaxSpeed, move.Degrees);

        public static BoundaryBreach BoundaryWouldBreach(PointD upperBoundary, PointD currentLocation, Common.Move move)
        {
            double deltaX = currentLocation.X + CalculateX(move);
            double deltaY = currentLocation.Y + CalculateY(move);

            return WouldHaveBreachedBoundary(upperBoundary, new PointD(deltaX, deltaY));
        }

        protected static BoundaryBreach WouldHaveBreachedBoundary(PointD upperBoundary, PointD point)
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
            BoundaryBreach boundaryBreach = WouldHaveBreachedBoundary(upperBoundary, nextPoint);

            if (boundaryBreach != BoundaryBreach.No)
            {
                double x = nextPoint.X;
                double y = nextPoint.Y;

                x = x < 0 ? 0 : x;
                y = y < 0 ? 0 : y;
                x = x > upperBoundary.X ? upperBoundary.X : x;
                y = y > upperBoundary.Y ? upperBoundary.Y : y;

                nextPoint = new PointD(x, y);
            }

            return new Location(nextPoint, boundaryBreach);
        }
    }
}
