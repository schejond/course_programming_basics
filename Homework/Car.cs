namespace Homework
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _year;
        private int _mileage;

        // konstruktor
        internal Car(string brand, string model, int year, int mileage)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _mileage = mileage;
        }

        // metoda
        public int Drive(int kilometers)
        {
            return _mileage + kilometers;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine("Brand: " + _brand + "  Model: " + _model + "  Year: " + _year + "  Mileage: " + _mileage + " km");
        }
    }
}
