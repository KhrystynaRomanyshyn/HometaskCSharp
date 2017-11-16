using System;

namespace MathFigure
{
    class Rectangle : IShape
    {
        private int _a;
        private int _b;

        public Rectangle(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("Sides must be positive");
            }

            _a = a;
            _b = b;
        }
        
        public double GetArea()
        {
            return _a*_b;
        }

        public string GetName()
        {
            return $"This is {GetType().Name}";
        }
    }
}