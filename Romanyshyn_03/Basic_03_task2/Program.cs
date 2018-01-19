using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_03_task2
{
    class Program
    {

        static void Main()
        {
            double firstNumber = 8;
            double commonRatio = 0.5;
            int limit = 1;
            int firstNum = 4;
            int difference = 2;
            int amountOfNumber = 3;

            ShowProductDecreaseGeometricProgression(firstNumber, commonRatio, limit);

            GetProductArithmeticProgression(firstNum, difference, amountOfNumber);
        }

        static double ShowProductDecreaseGeometricProgression(double firstNumber, double commonRatio, int limit, double product = 1)
        {
            if (Math.Abs(commonRatio) > 1)
            {
                throw new ArgumentException("Invalid value");
            }
            if (firstNumber < limit)
            {
                return product;
            }

            product = ShowProductDecreaseGeometricProgression(firstNumber * commonRatio, commonRatio, limit, firstNumber * product);
            return product;
        }

        static int GetProductArithmeticProgression(int firstNum, int difference, int amountOfNumbers)
        {
            if (amountOfNumbers <= 0 || difference == 0)
            {
                throw new ArgumentException("Invalid value");
            }

            int product = 1;
            for (int i = firstNum; i <= firstNum + (amountOfNumbers - 1) * difference; i = i + difference)
            {
                product *= i;
            }

            return product;
        }
    }
}