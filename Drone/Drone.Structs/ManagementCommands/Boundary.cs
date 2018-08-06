using System;
using System.Text.RegularExpressions;

namespace Drone.Commands
{
    public class Boundary : BaseCommand
    {
        private static string _regex = @"[bB](\d+\.?\d*),(\d+\.?\d*)";
        public PointD Point { get; }

        private Boundary() {} // Hide the default constructor.

        public Boundary(PointD upperBoundary) => Point = upperBoundary;

        public Boundary(string instruction)
        {
            Point = null;
            Match match = Regex.Match(instruction, _regex, RegexOptions.Singleline);
            if (match.Success && match.Groups.Count == 3)
            {
                if (double.TryParse(match.Groups[1].Value, out double x) &&
                    double.TryParse(match.Groups[2].Value, out double y))
                {
                    Point = new PointD(x,y);
                }
            }
            if (Point == null) { throw new ArgumentException(instruction); }
        }

        public new static bool InstructionIsForThisComand(string instruction)
        {
            Match match = Regex.Match(instruction, _regex, RegexOptions.Singleline);
            return (match.Success && match.Groups.Count == 3);
        }
    }
}
