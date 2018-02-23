using System;
using Ejercicio_Intive;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intive_FDV
{
    [TestClass]
    public class FamilyRentalTest
    {
        private HourlyRental _hourlyRental;
        private DailyRental _dailyRental;
        private WeeklyRental _weeklyRental;
        private FamilyRental _familyRental;
        private int _nBikes;
        private int _hours;
        private int _days;
        private int _weeks;

        [TestInitialize]
        public void InitialSetup()
        {

            _nBikes = 1;
            _hours = 3;
            _days = 2;
            _weeks = 1;

            _hourlyRental = new HourlyRental(_nBikes, _hours);
            _dailyRental = new DailyRental(_nBikes, _days);
            _weeklyRental = new WeeklyRental(_nBikes, _weeks);

            _familyRental = new FamilyRental();
            _familyRental.AddRental(_hourlyRental);
            _familyRental.AddRental(_dailyRental);
            _familyRental.AddRental(_weeklyRental);
        }
        [TestMethod]
        public void FamilyRentTest()
        {

            double totalByHour = _hourlyRental.GetPrice() * _hourlyRental.GetTime() * _hourlyRental.GetNumberOfBikes();
            double totalByDay = _dailyRental.GetPrice() * _dailyRental.GetTime() * _dailyRental.GetNumberOfBikes();
            double totalByWeek = _weeklyRental.GetPrice() * _weeklyRental.GetTime() * _weeklyRental.GetNumberOfBikes();
            double total = (totalByHour + totalByDay + totalByWeek) * 0.7;

            Assert.AreEqual(total, _familyRental.Rent(), 0);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void PromotionTest()
        {
            _familyRental.AddRental(new DailyRental(3,3));
        
        }

}
}
