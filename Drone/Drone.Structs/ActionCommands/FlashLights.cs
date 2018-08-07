namespace Drone.Commands
{
    public class FlashLights : BaseCommand
    {
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "F";
    }
}
