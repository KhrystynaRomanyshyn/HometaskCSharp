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
            var myPolinom = new OneVariablePolinom(1,1,1);
            var mySecondPolynom = new OneVariablePolinom(3, -4);

            var addition = myPolinom + mySecondPolynom;
            var subtraction = myPolinom - mySecondPolynom;
            var mult = myPolinom * mySecondPolynom;

            double d = myPolinom.Degree;
        }
    }
}