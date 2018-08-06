using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class Restart : BaseCommand
    {
        public Restart() {}
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "R";
    }
}
