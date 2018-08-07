namespace Drone.Commands
{
    public class Shutdown : BaseCommand
    {
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "D";
    }
}
