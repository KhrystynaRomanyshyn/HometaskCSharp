using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_04_task1
{
    class Program
    {
        static void Main()
        {
            Square mySquare = new Square();

            mySquare.Side = 6;

            int a = mySquare.Side;
            int p = mySquare.GetPerimeter();
            mySquare.Side = 8;
            int s = mySquare.Area;
        }
    }

    class Square
    {
        private int _side;

        public int Side
        {
            get
            {
                return _side;
            }

            set
            {
                if (value <= 0)
                {
                    throw new Exception();
                }

                _side = value;
            }
        }

        public int GetPerimeter()
        {
            return _side * 4;
        }

        public int Area
        {
            get
            {
                return _side * _side;
            }
        }
    }
}