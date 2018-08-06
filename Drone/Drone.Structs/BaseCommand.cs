using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public abstract class BaseCommand
    {
        public static bool InstructionIsForThisComand(string instruction) => throw new NotImplementedException();

        //public BaseCommand() {}

        //public BaseCommand(string instruction) {}
    }
}
