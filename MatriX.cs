using System;

namespace MatrixMultiplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Define the first 3x3 matrix
            int[,] matrixA = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Define the second 3x3 matrix
            int[,] matrixB = {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 }
            };

            // Resultant matrix to store the product
            int[,] result = new int[3, 3];

            // Compute the product of matrixA and matrixB
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = 0; // Initialize the resultant element
                    for (int k = 0; k < 3; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            // Display the resultant matrix
            Console.WriteLine("Resultant Matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
