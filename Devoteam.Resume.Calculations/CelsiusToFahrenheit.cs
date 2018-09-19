using System;
using Devoteam.Resume.Calculations.Interfaces;

namespace Devoteam.Resume.Calculations
{
    public class CelsiusToFahrenheit : ICelsiusToFahrenheit
    {
        public int Calculate(int celsius)
        {
            if (celsius < -1000000 || celsius > 1000000)
                throw new ArgumentOutOfRangeException();

            return 32 + (int) (celsius / 0.5556);
        }
    }
}
