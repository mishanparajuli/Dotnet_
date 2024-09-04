using System;

namespace Learning 
{
    internal class Jagg
    {
        public static void Main(string[] args)
        {
            // Initializing a jagged array with new numbers
            int[][] num = new int[3][];
            num[0] = new int[4] { 10, 20, 30, 40 };
            num[1] = new int[2] { 50, 60 };
            num[2] = new int[3] { 70, 80, 90 };

            // Display the elements of the jagged array
            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num[i].Length; j++)
                {
                    Console.Write(num[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
