namespace Drone.Structs
{
    public interface ICommand
    {
        bool InstructionIsForThisComand(string instruction);
    }
}