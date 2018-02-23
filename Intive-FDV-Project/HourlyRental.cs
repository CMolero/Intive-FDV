using System;

namespace Ejercicio_Intive
{
    public class HourlyRental : Rental
    {
        public HourlyRental(int nBikes, int hours)
        {
            if (nBikes < 1 || hours < 1) throw new FormatException();
            SetPrice(5.0);
            SetTime(hours);
            SetNumberOfBikes(nBikes);

        }
    }
}
