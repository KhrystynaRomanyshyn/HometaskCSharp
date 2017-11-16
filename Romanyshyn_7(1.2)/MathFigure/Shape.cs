namespace MathFigure
{
    abstract class Shape
    {
        public string GetName()
        {
            return $"This is {GetType().Name}";
        }

        public abstract double GetArea();
    }
}