using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_02_Task_01
{
    class Program
    {
        static void Main()
        {
            GetAvg(5, 7);

            SumEven(9);

            SumEven(9, 13);
        }

        static double GetAvg(int leftLimit, int rightLimit)
        {
            int sum = 0;
            if (leftLimit > rightLimit)
            {
                int temp;
                temp = leftLimit;
                leftLimit = rightLimit;
                rightLimit = temp;
            }

            for (int i = leftLimit; i <= rightLimit; i++)
            {
                sum += i;
            }

            double result = (double)sum / (rightLimit - leftLimit + 1);
            return result;
        }

        static int SumEven(int rightLimit)
        {
            int result = 0;
            for (int i = 0; i <= rightLimit; i += 2)
            {
                result += i;
            }

            return result;
        }

        static int SumEven(int leftLimit, int rightLimit)
        {
            if (leftLimit > rightLimit)
            {
                int temp;
                temp = leftLimit;
                leftLimit = rightLimit;
                rightLimit = temp;
            }

            int result = 0;
            for (int i = leftLimit; i <= rightLimit; i++)
            {
                if ((i % 2) == 0)
                {
                    result += i;
                }
            }

            return result;
        }
    }
}