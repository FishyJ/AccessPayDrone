namespace Drone.Commands
{
    public class Home : BaseCommand, IActionCommand
    {
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "H";
    }
}
