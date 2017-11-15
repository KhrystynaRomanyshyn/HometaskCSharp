using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFigure
{
    class Circle : Shape
    {
        private int radius;

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (radius < 0)
                    throw new Exception("Radius must be >0");
                radius = value;
            }
        }



        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }


        public override string GetName()
        {
            return string.Format("This is {0}", typeof(Circle));
        }

       

    }
}
