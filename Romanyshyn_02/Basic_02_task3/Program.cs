using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_02_task_3
{
    class Program
    {
        static void Main()
        {
            int[,] matrix =
            {
                { 2, 3, 5 },
                { 5, 3, 9 },
                { 1, 8, 4 }
            };

            TransformMatrix(matrix);
        }

        static void TransformMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        matrix[i, j] = 1;
                        continue;
                    }

                    if (i > j)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }
    }
}