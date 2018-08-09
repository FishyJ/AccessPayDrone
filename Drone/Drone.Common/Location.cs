using Drone.Common;

namespace Drone
{
    public class Location // Make class immutable, represents the stte of a location at a point in time.
    {
        public PointD Point { get; }
        public BoundaryBreach Breach { get; }

        public Location(PointD point, BoundaryBreach boundaryBreach)
        {
            Point = point;
            Breach = boundaryBreach;
        }

    }
}
