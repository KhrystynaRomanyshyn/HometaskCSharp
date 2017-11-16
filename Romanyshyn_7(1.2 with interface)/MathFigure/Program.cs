using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure
{
    class Program
    {
        static void Main()
        {
            try
            {
                Triangle triangle = new Triangle(3, 4, 5);
                double areaTriangle = triangle.GetArea();
                string nameTriangle = triangle.GetName();

                IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(3, 4);
                double areaIT = isoscelesTriangle.GetArea();
                string nameIT = isoscelesTriangle.GetName();

                Rectangle rectangle = new Rectangle(6, 7);
                double areaRectangle = rectangle.GetArea();

                Square square = new Square(9);
                double areaSquare = square.GetArea();

                Circle circle = new Circle(-10);
                double areaCircle = circle.GetArea();
            }
            catch(TriangleSideException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
