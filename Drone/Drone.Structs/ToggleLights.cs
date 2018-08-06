﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Commands
{
    public class ToggleLights: BaseCommand, ITrigger
    {
        public ToggleLights() {}

        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "T";
        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
