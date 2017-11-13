using Polinom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_05_task2
{
    class Program
    {
        static void Main()
        {
            var myPolinom = new OneVariablePolinom(1, 0, -2, 0);
            var mySecondPolynom = new OneVariablePolinom(3, 4, 5);

            var addition = myPolinom + mySecondPolynom;
            var subtraction = myPolinom - mySecondPolynom;
            var mult = myPolinom * mySecondPolynom;

            double d = myPolinom.Degree;
        }
    }
}