using System;

namespace Drone.Commands
{
    public abstract class BaseCommand
    {
        public string Instruction { get; private set; }
        public static bool InstructionIsForThisComand(string instruction) => throw new NotImplementedException();

        protected internal BaseCommand() {}

        protected BaseCommand(string instruction) => Instruction = instruction;
    }
}
