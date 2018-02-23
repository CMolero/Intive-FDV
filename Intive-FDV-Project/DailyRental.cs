using System;

namespace Ejercicio_Intive
{
    public class DailyRental:Rental
    {
        public DailyRental(int nBikes, int days)
        {
            if (nBikes < 1 || days < 1) throw new FormatException();
            SetNumberOfBikes(nBikes);
            SetPrice(20.0);
            SetTime(days);
        }
    }
}
