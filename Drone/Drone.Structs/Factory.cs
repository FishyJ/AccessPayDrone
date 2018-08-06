using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class Factory
    {
        private Factory() {} // Disable the default constructor.

        public static BaseCommand CreateCommand(string instruction)
        {
            if (Start.InstructionIsForThisComand(instruction)) { return new Start(); }
            if (Boundary.InstructionIsForThisComand(instruction)) { return new Boundary(instruction); }
            if (InitialPosition.InstructionIsForThisComand(instruction)) { return new InitialPosition(instruction); }
            if (Restart.InstructionIsForThisComand(instruction)) { return new Restart(); }
            if (Shutdown.InstructionIsForThisComand(instruction)) { return new Shutdown(); }
            if (ToggleLights.InstructionIsForThisComand(instruction)) { return new ToggleLights(); }
            if (FlashLights.InstructionIsForThisComand(instruction)) { return new FlashLights(); }
            if (Alert.InstructionIsForThisComand(instruction)) { return new Alert(instruction); }
            if (Home.InstructionIsForThisComand(instruction)) { return new Home(); }
            if (Move.InstructionIsForThisComand(instruction)) {  return new Move(instruction); }
            return null;
        }
    }
}
