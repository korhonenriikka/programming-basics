
namespace CarObjects
{
    public class Car
    {
        // Variables
        private double _speed;
        private readonly string _brand;

        //Constructors
        public Car(string brand)
        {
            _brand = brand;
            _speed = 0;
        }

        public Car()
        {
            _brand = "FORD";
            _speed = 10;
        }

        public Car(string brand, double speed)
        {
            _brand = brand;
            _speed = speed;
        }

        //Properties
        public string Brand
        {
            get { return _brand; }
        }

        public double Speed
        {
            get { return _speed; }
            private set { _speed = value; }
        }


        //Methods
        public void Accelerate(double acceleration)
        {
            _speed = _speed + acceleration;
        }

        public void Brake()
        {
            _speed = _speed - 10;
        }

        public override string ToString()
        {
            return Print();
        }

        private string Print()
        {
            return "Brand: " + Brand + ", Speed: " + Speed;
        }
    }
}
