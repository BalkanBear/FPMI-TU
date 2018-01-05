using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPlatform
{
    class MaxPlat
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1, 2, 3, 1, 4, 5, 7},
                {8, 7, 4, 5, 6, 2, 1},
                {4, 2, 5, 6, 8, 7, 5}
            };
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] +
                        matrix[row + 1, col + 1];
                    if (sum>bestSum)
                    {
                        bestRow = row;
                        bestCol = col;
                        bestSum = sum;
                    }
                }
            }

            Console.WriteLine("The best platform is: ");
            Console.WriteLine("  {0} {1}", matrix[bestRow,bestCol], matrix[bestRow+1,bestCol]);
            Console.WriteLine("  {0} {1}", matrix[bestRow,bestCol+1], matrix[bestRow+1,bestCol+1]);
            Console.WriteLine("The maximum sum is: {0}", bestSum);
        }
    }
}
