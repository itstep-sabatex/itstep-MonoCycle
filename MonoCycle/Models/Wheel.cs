using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MonoCycle.Models
{
    public sealed class Wheel : IDisposable
    {
        public double Mass { get; set; } = 1;
        public double Power { get; set; }
        public double WheelLength => wheelLength;
        public Direction Direction { get; set; }

        double wheelLength;
        private Timer _timer;


        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
