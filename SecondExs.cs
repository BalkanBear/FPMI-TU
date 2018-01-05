using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Exercise
{
    class SecondExs
    {
        static void Main(string[] args)
        {
            decimal[,] matrix = null;
            int choice;
            do
            {
                try
                {
                    Console.WriteLine("1. Въведете матрица, 2. Макс. главен диагонал");
                    choice = ReadInt("Команда: ");
                    switch (choice)
                    {
                        case 1:
                            matrix = ReadMatrix(ReadInt("n= "));
                            break;
                        case 2:
                            Console.WriteLine("Макс. диагонал е {0}", MaxOnMainDiag(matrix));
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Грешка:" + e.Message);
                }

            } while (choice != 0);

        }
        enum ResultCode
        {
            Success = 0,
            ArgumentNull,
            Unknown
        }
        static ResultCode MaxOnMainDiag(decimal[,] matrix, out decimal max)
        {
            if (matrix != null)
            {
                max = matrix[0, 0];
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, i] > max)
                    {
                        max = matrix[i, i];
                    }
                }
                return ResultCode.Success;
            }
            max = 0;//make computer happy :)
            return ResultCode.ArgumentNull;
        }
        static int ReadInt(string prompt)
        {
            Console.WriteLine("Въведете команда: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    }
}
