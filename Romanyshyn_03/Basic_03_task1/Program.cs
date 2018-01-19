using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_03_task1
{
    enum Sorting
    {
        Increase,
        Decrease
    }

    class Program
    {
        static void Main()
        {
            int[] array = { 2, 2, 8, 1, 2, 8, 6, 5 };
            SortArray(array, Sorting.Increase);

            int[] arraySort = { 3, 6, 8, 6 };
            IsSorted(arraySort, Sorting.Increase);

        }

        static void SortArray(int[] array, Sorting orderBy)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if ((orderBy == Sorting.Increase && array[i - 1] > array[i]) ||
                        (orderBy == Sorting.Decrease && array[i - 1] < array[i]))
                    {
                        int temp;
                        temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }
            }
        }

        static bool IsSorted(int[] array, Sorting orderBy)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if ((orderBy == Sorting.Increase && array[i] < array[i - 1]) ||
                    (orderBy == Sorting.Decrease && array[i - 1] < array[i]))
                    return false;
            }
            
            return true;
        }
    }
}