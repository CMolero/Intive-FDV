using System;

namespace Ejercicio_Intive
{
    public class WeeklyRental:Rental
    {
        public WeeklyRental(int nBikes, int weeks)
        {
            if (nBikes < 1 || weeks < 1) throw new FormatException();

            SetPrice(60.0);
            SetTime(weeks);
            SetNumberOfBikes(nBikes);

        }
    }
}
