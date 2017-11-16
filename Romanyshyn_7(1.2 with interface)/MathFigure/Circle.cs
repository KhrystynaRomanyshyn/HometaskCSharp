using System;

namespace MathFigure
{
    class Circle : IShape
    {
        private int _radius;

        public Circle(int radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be > 0");
            }

            _radius = radius;
        }

        public double GetArea()
        {
            return Math.Round(Math.PI * _radius * _radius, 2);
        }

        public string GetName()
        {
            return $"This is {GetType().Name}";
        }
    }
}