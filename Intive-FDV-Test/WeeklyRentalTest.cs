using System;
using Ejercicio_Intive;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intive_FDV
{
    [TestClass]
    public class WeeklyRentalTest
    {
        private WeeklyRental _weeklyRental;
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ZeroValTest()
        {
            _weeklyRental = new WeeklyRental(0, 5);
            _weeklyRental.Rent();
            _weeklyRental = new WeeklyRental(5, 0);
            _weeklyRental.Rent();
            _weeklyRental = new WeeklyRental(0, 0);
            _weeklyRental.Rent();
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NegativeValTest()
        {
            _weeklyRental = new WeeklyRental(-1, 5);
            _weeklyRental.Rent();
            _weeklyRental = new WeeklyRental(5, -1);
            _weeklyRental.Rent();
            _weeklyRental = new WeeklyRental(-1, -1);
            _weeklyRental.Rent();
        }
        [TestMethod]
        public void PriceTest()
        {
            _weeklyRental = new WeeklyRental(2, 6);
            Assert.AreEqual(60.0, _weeklyRental.GetPrice(), 0.01);
        }
        [TestMethod]
        public void TimeTest()
        {
            _weeklyRental = new WeeklyRental(2, 7);
            Assert.AreEqual(7, _weeklyRental.GetTime());
        }
    }
}
