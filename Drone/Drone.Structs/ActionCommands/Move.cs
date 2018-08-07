using System;
using System.Text.RegularExpressions;

namespace Drone.Commands
{
    public class Move : BaseCommand, ITrigger
    {
        private static string _regex = @"[mM](\d+\.?\d*),(\d+\.?\d*)";
        public double Time { get; }
        public double Direction { get; }
        private Move() {} // Disable default constructor.

        public Move(string instruction)
        {
            bool success = false;
            Match match = Regex.Match(instruction, _regex, RegexOptions.Singleline);
            if (match.Success && match.Groups.Count == 3)
            {
                if (double.TryParse(match.Groups[1].Value, out double seconds) &&
                    double.TryParse(match.Groups[2].Value, out double degrees))
                {
                    Time = seconds;
                    Direction = degrees;
                    success = true;
                }
            }
            if (!success) { throw new ArgumentException(instruction); }
        }
        public Move(double seconds, double degree)
        {
            Time = seconds;
            Direction = degree;
        }

        public new static bool InstructionIsForThisComand(string instruction)
        {
            Match match = Regex.Match(instruction, _regex, RegexOptions.Singleline);
            return (match.Success && match.Groups.Count == 3);
        }

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
