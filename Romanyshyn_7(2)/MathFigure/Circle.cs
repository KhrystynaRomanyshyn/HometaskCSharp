using System;

namespace MathFigure
{
    class Circle : Shape
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

        public override double GetArea()
        {
            return Math.Round(Math.PI * _radius * _radius, 2);
        }
    }
}
