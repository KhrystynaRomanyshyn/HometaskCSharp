using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_04_task2
{
    class Program
    {
        static void Main()
         {

            ArithmeticProgression prog = new ArithmeticProgression();
            prog.FirstNumber = 5;
            prog.Difference = 2;
            prog.AmountOfNumber = 4;
            int nthNumber = prog.GetNthNumber();
            int sum = prog.GetSum();
            double average = prog.GetAverage();
        }
    }

    class ArithmeticProgression
    {
        public int FirstNumber { get; set; } // спробувати з прайват сет, а гет паблік

        public int AmountOfNumber { get; set; }

        public int Difference { get; set; }

        public int GetNthNumber()
        {
            return FirstNumber + (AmountOfNumber - 1) * Difference;
        }

        public int GetSum()
        {
            return (FirstNumber + GetNthNumber()) / 2 * AmountOfNumber;
        }

        public double GetAverage()
        {
            return GetSum() / AmountOfNumber;
        }
    }
}