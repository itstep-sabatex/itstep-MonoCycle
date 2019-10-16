using System;
using System.Collections.Generic;
using System.Text;

namespace MonoCycle.Models
{
    public sealed class Wheel : IDisposable
    {
        public double Mass { get; set; } = 1;
        public double Power { get; set; }
        public double WheelLength => wheelLength;
        public Direction Direction { get; set; }

        double wheelLength;


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
