using System;
using Ejercicio_Intive;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intive_FDV
{
    [TestClass]
    public class HourlyRentalTest
    {
        private HourlyRental _hourlyRental;
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ZeroValTest()
        {
            _hourlyRental = new HourlyRental(0, 5);
            _hourlyRental.Rent();
            _hourlyRental = new HourlyRental(5, 0);
            _hourlyRental.Rent();
            _hourlyRental = new HourlyRental(0, 0);
            _hourlyRental.Rent();
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NegativeValTest()
        {
            _hourlyRental = new HourlyRental(-1, 5);
            _hourlyRental.Rent();
            _hourlyRental = new HourlyRental(5, -1);
            _hourlyRental.Rent();
            _hourlyRental = new HourlyRental(-1, -1);
            _hourlyRental.Rent();
        }
        [TestMethod]
        public void PriceTest()
        {
            _hourlyRental = new HourlyRental(2, 5);
            Assert.AreEqual(5.0, _hourlyRental.GetPrice(), 0.01);
        }
        [TestMethod]
        public void TimeTest()
        {
            _hourlyRental = new HourlyRental(2, 8);
            Assert.AreEqual(8, _hourlyRental.GetTime());
        }
    }
}
