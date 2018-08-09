namespace Drone.Commands
{
    public class Restart : BaseCommand
    {
        public Restart() : base("R") {}
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "R";
    }
}
