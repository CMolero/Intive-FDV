namespace Ejercicio_Intive
{
    public abstract class Rental
    {
        private double _price;
        private int _nBikes;
        private int _time;

        public double Rent()
        {
            return GetNumberOfBikes() * GetPrice() * GetTime();
        }
        public double GetPrice()
        {
            return _price;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }
        public int GetTime()
        {
            return _time;
        }
        public void SetTime(int time)
        {
            _time = time;
        }
        public int GetNumberOfBikes()
        {
            return _nBikes;
        }
        public void SetNumberOfBikes(int nBikes)
        {
            _nBikes = nBikes;
        }
    }
}
