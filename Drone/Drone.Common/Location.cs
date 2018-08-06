using Drone.Common;

namespace Drone
{
    public class Location // Make class immutable, represents the stte of a location at a point in time.
    {
        public PointD Point { get; }
        public BoundaryBreached Breached { get; }

        public Location(PointD point, BoundaryBreached boundaryBreached)
        {
            Point = point;
            Breached = boundaryBreached;
        }

        public static Location NextLocation(PointD upperBoundary, Location curentLocation, PointD moveBy)
        {
            PointD nextPoint = PointD.NextPoint(curentLocation.Point, moveBy);
            return new Location(nextPoint, PointD.WouldHaveBreachedBoundary(upperBoundary, nextPoint));
        }

    }
}
