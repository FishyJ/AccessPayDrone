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
