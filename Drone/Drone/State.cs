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

        public PointD InitialPosition { get; private set; }
        public PointD Boundary { get; private set; }
        public Location CurrentLocation { get; }
        public bool Started { get; }
        public bool LightsOn { get; private set; }

        private Queue<BaseCommand> _commandQueue;
        private Queue<BaseCommand> _additionalCommands;

        public void AddCommand(string instruction) => _commandQueue.Enqueue(Factory.CreateCommand(instruction));

        public State()
        {
            Reset();
            _commandQueue = new Queue<BaseCommand>();
            _additionalCommands = new Queue<BaseCommand>();


            _timer = new System.Timers.Timer(0.5 * 1000) {AutoReset = true}; // 0.5 secs.
            _timer.Elapsed += Tick;
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

        private void DoCommand(BaseCommand command)
        {
            if (command == null) { throw  new ArgumentNullException("command"); }
            if (!Started && ((command is Shutdown) || !(command is Start))) { throw new InvalidStateException("Drone not yet started!"); }
            if (Started && (command is Start)) { throw new InvalidStateException("Drone already started!"); }

            if (command is Restart) { Reset(); }

            if (Boundary == null && !(command is Boundary)) { throw new InvalidStateException("Boundary has not been set!"); }

            if (command is InitialPosition) { InitialPosition = ((InitialPosition) command).Point; }
            if (command is ToggleLights) { ToggleLights((ToggleLights)command); }
            if (command is FlashLights) { FlashLights(); }

            if (command is Alert) { Alert((Alert)command); }
        }

        private void ToggleLights(ToggleLights toggleLights)
        {
            LightsOn = !LightsOn;
            throw new NotImplementedException();
        }

        private void FlashLights()
        {
            throw new NotImplementedException();
        }

        private void Alert(Alert alert)
        {
            // Sound horn for alert.RemainingSeconds.
            throw new NotImplementedException();
        }

        private void Reset()
        {
            InitialPosition = new PointD(0, 0); // Default initial position.
            Boundary = null; // Set boundary invalid for command test.
        }

        private double CleanDirection(double direction)
        {
            double _direction = direction;
            while (_direction < 0) { _direction += 360; } // remove -ve bearings to become +ve bearings of the same direction.
            return _direction % 360; // Make the bearing in the range 0 to 359 degrees;
        }
    }
}
