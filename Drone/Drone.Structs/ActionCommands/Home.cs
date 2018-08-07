namespace Drone.Commands
{
    public class Home : BaseCommand
    {
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "H";
    }
}
