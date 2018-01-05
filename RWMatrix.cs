using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteMatrix
{
    class RWMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] myMatrix = new int[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write("matrix[{0},{1}]: ", row, col );
                    myMatrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("The full matrix is: ");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write("{0} ", myMatrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
