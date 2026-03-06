namespace GeometricFigure.Backend
{
    public class Circle : GeometricFigures
    {
        // Fields
        private double _r;

        // Constructors
        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }

        // Properties
        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        // Methods
        public override double GetArea() => 3.1415926 * Math.Pow(R,2);
        public override double GetPerimeter() => 2 * 3.1415926 * R;
        private double ValidateR(double r)
        {
            if (r < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Circle),$"The radius: {r} is invalid");
            }
            return r;
        }
    }
}
