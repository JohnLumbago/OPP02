namespace GeometricFigure.Backend
{
    public abstract class GeometricFigures
    {
        // Properties
        public string Name
        {
            get; 
            set; 
        }

        // Methods
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString()
        {
            return $"{Name,-15} => Area.....:{GetArea(),15:N5}      Perimeter:{GetPerimeter(),15:N5}";
        }
    }
}
