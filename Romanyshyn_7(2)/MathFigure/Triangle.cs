using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure
{
    class Triangle : Shape
    {
        private int _a;
        private int _b;
        private int _c;

        public Triangle(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Sides must be positive");
            }
            if (a+b>c && a+c>b && b+c>a)
            {
                _a = a;
                _b = b;
                _c = c;
            }
            else throw new Exception("The sum of two sides must be bigger than third side.");
        }

        public override double GetArea()
        {
            double _halfPerimeter = (_a + _b + _c) / 2;
            return Math.Sqrt(_halfPerimeter * (_halfPerimeter - _a) * (_halfPerimeter - _b) * (_halfPerimeter - _c));
        }

        public override string GetName()
        {
            return string.Format("This is {0}", typeof(Triangle));
        }
    }
}
