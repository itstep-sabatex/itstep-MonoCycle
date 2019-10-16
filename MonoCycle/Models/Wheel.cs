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
        double diameter;
        private Timer _timer;

        private Wheel(double diametr)
        {
            this.diameter = diametr;
            wheelLength = diametr * Math.PI;
            //t1 = 0;
            //v1 = 0;
            _timer = new Timer(20);
            //_timer.Elapsed += OnElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wheelSize"></param>
        /// <returns></returns>
        public static Wheel CreateWheel(WheelSize wheelSize) =>
            wheelSize switch
            {
                WheelSize.d10 => new Wheel(0.25),
                WheelSize.d12 => new Wheel(0.3),
                WheelSize.d14 => new Wheel(0.36),
                WheelSize.d16 => new Wheel(0.41),
                WheelSize.d18 => new Wheel(0.46),
                WheelSize.d22 => new Wheel(0.56),
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(wheelSize))

            };

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
