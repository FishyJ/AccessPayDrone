using System;
using System.Text.RegularExpressions;
using System.Timers;

namespace Drone.Commands
{
    public class Alert : BaseCommand, IActionCommand, ITrigger
    {
        private static string _regex = @"[aA](\d+\.?\d*)";
        private System.Timers.Timer _timer;
        public double RemainingSeconds { get; private set; }
        public event AlertEventArgs.AlertEventHandler AlertRaised;
        private Alert() {}


        public Alert(double seconds)
        {
            RemainingSeconds = seconds;
            _timer = new Timer(0.125 * 1000); // 1/8th second.
            _timer.Elapsed += _timer_Elapsed;
            _timer.AutoReset = true;
            //_timer.Start();
        }

        public Alert(string instruction) : base(instruction)
        {
            Match match = Regex.Match(instruction, _regex, RegexOptions.Singleline);
            if (double.TryParse(match.Groups[1].Value, out double seconds))
            {
                RemainingSeconds = seconds;
            }
        }

        public new static bool InstructionIsForThisComand(string instruction)
        {
            Match match = Regex.Match(instruction, _regex, RegexOptions.Singleline);

            return (match.Success && match.Groups.Count == 2);
        }

        ~Alert()
        {
            _timer?.Dispose();
        }

        public void Trigger()
        {
            _timer.Start();
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            RemainingSeconds -= _timer.Interval;
            if (RemainingSeconds >= 0)
            {
                //do alert!
                
            }
            else
            {
                _timer.Stop();
                _timer.Dispose();
            }
            throw new NotImplementedException();
        }

        protected virtual void OnAlert(AlertEventArgs e)
        {
            AlertEventArgs.AlertEventHandler handler = AlertRaised;
            if (handler != null) { handler(this, e); }
        }
    }
}
