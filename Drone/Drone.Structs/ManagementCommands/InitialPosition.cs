using System;
using System.Text.RegularExpressions;

namespace Drone.Commands
{
    public class InitialPosition : BaseCommand
    {
        private static string _regex = @"[pP](\d+\.?\d*),(\d+\.?\d*)";
        public PointD Point { get; }

        private InitialPosition(){} // Hide the default constructor.

        public InitialPosition(PointD initialPoint) => Point = initialPoint;

        public InitialPosition(string instruction) : base(instruction)
        {
            Point = null;
            Match match = Regex.Match(instruction, _regex, RegexOptions.Singleline);
            if (match.Success && match.Groups.Count == 3)
            {
                if (double.TryParse(match.Groups[1].Value, out double x) &&
                    double.TryParse(match.Groups[2].Value, out double y))
                {
                    Point = new PointD(x, y);
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
