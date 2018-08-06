using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class Move : BaseCommand, ITrigger
    {
        public double Time { get; }
        public double Direction { get; }
        private Move() {} // Disable default constructor.

        public Move(string instruction)
        {
            throw new NotImplementedException();
        }
        public Move(double seconds, double degree)
        {
            Time = seconds;
            Direction = degree;
        }

        public new static bool InstructionIsForThisComand(string instruction)
        {
            throw new NotImplementedException();
        }

        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
