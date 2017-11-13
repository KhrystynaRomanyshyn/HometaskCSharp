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

            int[,] matrixA = { {1,2},{ 3, 4 } };
            int[,] matrixB = { { 5,6,7 }, { 8, 9, 10 } };
            int[,] matrixC = { { 2, 3, 1 }, { 1, 7, 0 } };
            int ryadku = matrixA.GetLength(0);

            try
            {
                int[,] sum = Matrix.Add(matrixB, matrixC);
                int[,] subb = Matrix.Sub(matrixB, matrixC);
            }
            catch (ArgumentException exeption)
            {
                Console.WriteLine(exeption.Message);
            }

            try
            {
                int[,] mult = Matrix.Multiply(matrixA, matrixB);
            }
            catch(ArgumentException ex )
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Matrix
    {
        public static int[,] AddOrSub(int[,] A, int[,] B, bool isAdd)
        {
            if ((A.GetLength(0) != B.GetLength(0)) || (A.GetLength(1) != B.GetLength(1)))
            {
                throw new ArgumentException("Dimension of the matrices should be the same.");
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
                throw new ArgumentException("The number of columns in the first matrix should be equal to the numbers of lines of the second.");
            }

            {
                int[,] result = new int[A.GetLength(0), B.GetLength(1)];
                for (int k = 0; k < A.GetLength(1) ; k++)
                {
                    for (int l = 0; l < B.GetLength(1); l++)
                    {

                        for (int s = 0; s <= A.GetLength(0)-1; s++)
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
