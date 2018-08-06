using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class Home : BaseCommand
    {
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "H";
    }
}
