using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_02_task2
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 10, 5, 10, 3 };

            ChangeDirection(numbers);

            GetDistanceBetweenExtremsMaxNumbers(numbers);
        }

        static int GetDistanceBetweenExtremsMaxNumbers(int[] array)
        {
            int leftMaxElement = 0;
            int maxArrayNumber = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxArrayNumber)
                {
                    leftMaxElement = i;
                    break;
                }
            }

            int rightMaxElement = 0;
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] == maxArrayNumber)
                {
                    rightMaxElement = i;
                    break;
                }
            }

            return rightMaxElement - leftMaxElement;
        }

        static void ChangeDirection(int[] array)
        {
            for (int j = 0, k = 1; j < array.Length / 2; j++, k++)
            {
                int temp = array[j];
                array[j] = array[array.Length - k];
                array[array.Length - k] = temp;
            }
        }
    }
}