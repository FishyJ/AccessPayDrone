using System;

namespace Drone.Commands
{
    public class ToggleLights: BaseCommand, IActionCommand, ITrigger
    {
        public event ToggleLightsEventArgs.ToggleLightsEventHandler Toggle;
        public ToggleLights() {}

        public new static bool InstructionIsForThisComand(string instruction) => instruction.ToUpperInvariant() == "T";
        public void Trigger()
        {
            OnToggle(new ToggleLightsEventArgs());
        }

        protected virtual void OnToggle(ToggleLightsEventArgs e)
        {
            ToggleLightsEventArgs.ToggleLightsEventHandler handler = Toggle;
            if (handler != null) handler(this, e);
        }
    }
}
