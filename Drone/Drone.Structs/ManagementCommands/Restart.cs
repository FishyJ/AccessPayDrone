namespace Drone.Commands
{
    public class Restart : BaseCommand
    {
        public Restart() {}
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "R";
    }
}
