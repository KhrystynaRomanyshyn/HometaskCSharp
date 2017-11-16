using System;

namespace MathFigure
{
    class Triangle : IShape
    {
        private int _a;
        private int _b;
        private int _c;

        public Triangle(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Sides must be positive");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new TriangleSideException("The sum of two sides must be bigger than third side.");
            }

            _a = a;
            _b = b;
            _c = c;
        }

        public double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Round(Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)), 2);
        }

        public string GetName()
        {
            return $"This is {GetType().Name}";
        }
    }
}
