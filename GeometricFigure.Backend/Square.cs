namespace GeometricFigure.Backend
{
    public class Square : GeometricFigures
    {
        // Fields
        private double _a;

        // Constructors
        public Square(string name, double a)
        {
            Name = name;
            A = a;
        }

        // Properties
        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        // Methods
        public override double GetArea() => Math.Pow(A,2);
        public override double GetPerimeter() => 4 * A;
        private double ValidateA(double a)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Square),$"The value: {a} is invalid");
            }
            return a;
        }
    }
}
