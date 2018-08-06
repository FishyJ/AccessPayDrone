using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Drone.Commands
{
    public class Alert : BaseCommand, ITrigger
    {
        private System.Timers.Timer _timer;
        private double _remainingSeconds;
        private Alert() {}

        public new static bool InstructionIsForThisComand(string instruction)
        {
            throw new NotImplementedException();
        }

        public Alert(double seconds)
        {
            _remainingSeconds = seconds;
            _timer = new Timer(0.125 * 1000); // 1/8th second.
            _timer.Elapsed += _timer_Elapsed;
            _timer.AutoReset = true;
            //_timer.Start();
        }

        public Alert(string instruction)
        {
            throw new NotImplementedException();
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
            _remainingSeconds -= _timer.Interval;
            if (_remainingSeconds >= 0)
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
    }
}
