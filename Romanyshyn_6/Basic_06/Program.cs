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

            int[,] matrixA = { { 1, 2, 3 }, { 2, -1, 2 } };
            int[,] matrixB = { { 3, 2, 1 }, { 1, 3, -2 }, { 2, 4, 2 } };
            int ryadku = matrixA.GetLength(0);

            //  int[,] sum = Matrix.Add(matrixA, matrixB);
            //  int[,] subb = Matrix.Sub(matrixA, matrixB);
            int[,] mult = Matrix.Multiply(matrixA, matrixB);

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

        public static int[,] Multiply(int[,] A, int[,] B)
        {
            if (A.GetLength(1) != B.GetLength(0))
            {
                throw new Exception("The number of columns in the first matrix should be equal to the numbers of lines of the second.");
            }

            {
                int[,] result = new int[A.GetLength(0), B.GetLength(1)];
                for (int k = 0; k < A.GetLength(1) - 1; k++)
                {
                    for (int l = 0; l < B.GetLength(1); l++)
                    {

                        for (int s = 0; s <= A.GetLength(0); s++)
                        {
                            result[k, l] += A[k, s] * B[s, l];
                        }
                    }
                }

                return result;
            }
        }
    }
}
