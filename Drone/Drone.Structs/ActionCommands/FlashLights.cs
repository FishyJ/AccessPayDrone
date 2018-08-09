namespace Drone.Commands
{
    public class FlashLights : BaseCommand, IActionCommand
    {
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "F";

        public FlashLights() : base("F") {}
    }
}
