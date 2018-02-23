using System;
using System.Collections.Generic;

namespace Ejercicio_Intive
{
    public class FamilyRental : Rental
    {
        private double _total;
        private readonly List<Rental> _rentals = new List<Rental>();

        public void AddRental(Rental rental)
        {

            if (rental.GetNumberOfBikes() + GetNumberOfBikes() > 5) throw new FormatException();

            _rentals.Add(rental);
        }

        protected new virtual int GetNumberOfBikes()
        {
            int numberOfBikes = 0;
            foreach (Rental i in _rentals)
            {
                numberOfBikes += i.GetNumberOfBikes();
            }

            return numberOfBikes;
        }

        

        public new virtual double Rent()
        {
            if (GetNumberOfBikes() < 3)
            {
                Console.WriteLine("You only get the promotion if you rent at least 3 bikes!"); 
                return 0;
            }

            _total = 0;
            foreach (Rental i in _rentals)
            {
                _total += i.Rent();
            }
            _total *= 0.7;
            return _total;
        }

    }
}
