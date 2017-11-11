using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_06
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrixA = { { 1, 1,1 }, { 1, 1,1}, { 1, 1,1 } };
            int[,] matrixB = { { 1, 1,1 }, { 1, 1,1 }, { 1, 1,1 } };

            int[,] sum = Matrix.Add(matrixA, matrixB);
            int[,] subb = Matrix.Sub(matrixA, matrixB);

        }
    }

    class Matrix
    {
        public static int[,] AddOrSub(int[,] A, int[,] B, bool isAdd)
        {
            if ((A.GetLength(0) != B.GetLength(0)) || (A.GetLength(1) != B.GetLength(1)))
            {
                throw new Exception("Dimension of the matrices should be the same.");
            }

            int[,] result = new int[A.GetLength(0), A.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (isAdd)
                    {
                        result[i, j] = A[i, j] + B[i, j];
                    }

                    else
                    {
                        result[i, j] = A[i, j] - B[i, j];
                    }
                }
            }

            return result;
        }

        public static int[,] Add(int[,] A, int[,] B)
        {
            return AddOrSub(A, B, true);
        }

        public static int[,] Sub(int[,] A, int[,] B)
        {
            return AddOrSub(A, B, false);
        }

        pu

    }
}
