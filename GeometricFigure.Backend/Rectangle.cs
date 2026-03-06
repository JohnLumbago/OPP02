namespace GeometricFigure.Backend
{
    public class Rectangle : Square
    {
        // Fields
        private double _b;

        // Constructors
        public Rectangle(string name, double a, double b) :
            base(name, a)
        {
            Name = name;
            B = b;
        }

        // Properties
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        // Methods
        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
        private double ValidateB(double b)
        {
            if (b < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rectangle), $"The value: {b} is invalid.");
            }
            return b;
        }
    }
}
