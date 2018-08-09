using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Drone;
using Drone.Commands;

namespace Drone
{
    public class State
    {
        private System.Timers.Timer _timer;
        private static State _state;

        public StateEventArgs.StateEventHandler StateChange;
        public StateEventArgs.StateEventHandler StateError;

        public PointD InitialPosition { get; private set; }
        public PointD Boundary { get; private set; }
        public Location CurrentLocation { get; }
        public bool Started { get; }
        public bool LightsOn { get; private set; }

        private Queue<BaseCommand> _commandQueue;
        private Queue<BaseCommand> _additionalCommands;

        protected virtual void OnStateChange(StateEventArgs e)
        {
            StateEventArgs.StateEventHandler handler = StateChange;
            handler?.Invoke(this, e);
        }
        protected virtual void OnStateError(StateEventArgs e)
        {
            StateEventArgs.StateEventHandler handler = StateError;
            handler?.Invoke(this, e);
        }

        public void AddCommand(string instruction) => _commandQueue.Enqueue(Factory.CreateCommand(instruction));

        public State()
        {
            Restart();
            _commandQueue = new Queue<BaseCommand>();
            _additionalCommands = new Queue<BaseCommand>();


            _timer = new System.Timers.Timer(0.5 * 1000) {AutoReset = true}; // 0.5 secs.
            _timer.Elapsed += Tick;
            _timer.Start();
        }

        private void Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            ProcessQueue();
        }

        public void ProcessQueue()
        {
            if (_additionalCommands.Any()) { DoCommand(_additionalCommands.Dequeue()); }
            else { if (_commandQueue.Any()) { DoCommand(_commandQueue.Dequeue()); } }
        }

        private bool ReadyToRoll() => Started && Boundary != null;

        private void DoCommand(BaseCommand command)
        {
            if (command == null) { throw new ArgumentNullException(nameof(command)); }

            if (!Started && ((command is Shutdown) || !(command is Start)))
            {
                OnStateError(new StateEventArgs() {Command = command, Message = "Drone not yet started!"});
                return;
            }

            if (Started && (command is Start))
            {
                OnStateError(new StateEventArgs() { Command = command, Message = "Drone already started!" });
                return;
            }

            if (command is Restart) { Restart(); }

            if (Boundary == null && !(command is Boundary))
            {
                OnStateError(new StateEventArgs() { Command = command, Message = "Boundary has not been set!" });
                return;
            }

            if (!ReadyToRoll() && command is IActionCommand)
            {
                OnStateError(new StateEventArgs() { Command = command, Message = "Cannot process action commands unless the drone is started and has a boundary." });
                return;
            }

            if (command is InitialPosition position) { InitialPosition = position.Point; }

            if (command is ITrigger trigger) { trigger.Trigger(); }

            if (command is ToggleLights lights) { ToggleLights(lights); }
            if (command is FlashLights) { FlashLights(); }

            if (command is Alert alert) { Alert(alert); }
            if (command is Home) { }
        }

        private void ToggleLights(ToggleLights toggleLights)
        {
            LightsOn = !LightsOn;
            OnStateChange(new StateEventArgs() {Command = toggleLights});
        }

        private void FlashLights()
        {
            OnStateChange(new StateEventArgs() { Command = new FlashLights() });
        }

        private void Alert(Alert alert)
        {
            // Sound horn for alert.RemainingSeconds.
            OnStateChange(new StateEventArgs() { Command = alert });
            throw new NotImplementedException();
        }

        private void Home()
        {
            Move move = new Move(PointD.CalculateHypotenuse(CurrentLocation.Point,InitialPosition), PointD.CalculateDegrees(CurrentLocation.Point, InitialPosition));
            _additionalCommands.Enqueue(move);
            OnStateChange(new StateEventArgs() { Command = new Home() });
        }

        private void Restart()
        {
            InitialPosition = new PointD(0, 0); // Default initial position.
            Boundary = null; // Set boundary invalid for command test.
            OnStateChange(new StateEventArgs() { Command = new Restart() });
        }

        private double CleanDirection(double direction)
        {
            double _direction = direction;
            while (_direction < 0) { _direction += 360; } // remove -ve bearings to become +ve bearings of the same direction.
            return _direction % 360; // Make the bearing in the range 0 to 359 degrees;
        }
    }
}
