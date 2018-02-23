using System;
using Ejercicio_Intive;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intive_FDV
{
    [TestClass]
    public class DailyRentalTest
    {
        private DailyRental _dailyRental;
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ZeroValTest()
        {
            _dailyRental = new DailyRental(0, 5);
            _dailyRental.Rent();
            _dailyRental = new DailyRental(5, 0);
            _dailyRental.Rent();
            _dailyRental = new DailyRental(0, 0);
            _dailyRental.Rent();
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NegativeValTest()
        {
            _dailyRental = new DailyRental(-1, 5);
            _dailyRental.Rent();
            _dailyRental = new DailyRental(5, -1);
            _dailyRental.Rent();
            _dailyRental = new DailyRental(-1, -1);
            _dailyRental.Rent();
        }
        [TestMethod]
        public void PriceTest()
        {
            _dailyRental = new DailyRental(3, 5);
            Assert.AreEqual(20.0, _dailyRental.GetPrice(), 0.01);
        }
        [TestMethod]
        public void TimeTest()
        {
            _dailyRental = new DailyRental(2, 8);
            Assert.AreEqual(8, _dailyRental.GetTime());
        }
    }
}
