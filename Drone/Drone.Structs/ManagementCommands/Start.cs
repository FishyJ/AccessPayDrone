namespace Drone.Commands
{
    public class Start : BaseCommand
    {
        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "S";

        public Start() : base("S") {}
    }
}
