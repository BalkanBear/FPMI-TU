using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Array
    {
        static void Main(string[] args)
        {
            Console.Write("Input rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Input cols: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows,cols];
            for (int row = 0; row < rows; row++)
            {
                string rowValues = Console.ReadLine();
                string[] values = rowValues.Split();
                for (int col = 0; col < values.Length; col++)
                {
                    matrix[row,col] = int.Parse(values[col]);
                }

            }
            int rowMax = 0, colMax = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] > matrix[rowMax, colMax])
                    {
                        rowMax = row;
                        colMax = col;
                    }
                    Console.WriteLine("Row = {0}, Col = {1}", rowMax + 1, colMax + 1);
                }
            }
        }
    }
}
