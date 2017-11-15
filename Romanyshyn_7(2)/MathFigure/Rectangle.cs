using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure
{
    class Rectangle : Shape
    {
        int[] sides;
        public int[] Sides
        {
            get
            {
                return sides;
            }
            set
            {
                if (value[0] <= 0 || value[1] <= 0)
                {
                    throw new Exception("Sides must be positive");
                }
                sides = value;
            }
        }
        public override double GetArea()
        {
            return Sides[0]*Sides[1];
        }

        public override string GetName()
        {
            return string.Format("This is {0}", typeof(Rectangle));
        }

       
    }
}
