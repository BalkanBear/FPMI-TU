using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matr
    {
        static void Main(string[] args)
        {
            decimal[,] matrix = null;
            int choice;
            do
            {
                Console.WriteLine("1-Въведете матрица, 2-Макс.по диагонал");
                choice = ReadInt("Вашият избор е: ");
                switch (choice)
                {
                    case 1:
                        matrix = ReadMatrix(ReadInt("n= "));
                        break;
                    case 2:
                        decimal max;
                        ResultCode res = MaxOnMainDiag(matrix, out max);
                        if (res==ResultCode.Success)
                        {
                            Console.WriteLine("Max e {0}", max);
                        }
                        else if(res==ResultCode.ArgumentNull)
                        {
                            Console.WriteLine("Моля въведете матрица: ");
                        }
                        else
                            Console.WriteLine("Неочаквана грешка.");
                        break;
                }
            } while (choice != 0);
            
        }
        static decimal MaxOnMainDiag(decimal[,]matrix)
        {
            if(matrix!=null)
            {
                var max = matrix[0, 0];
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i,i]>max)
                    {
                        max = matrix[i, i];
                    }
                    return max;
                }
            }
            throw new Exception("Не е подадена матрица.");
            if(matrix==null)
            {
                var max = matrix[0, 0];
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i,i]>max)
                    {
                        max = matrix[i, i];
                    }
                }
                
            }
            throw new Exception("Няма матрица.");
        }
        enum ResultCode
        {
            Success = 0,
            ArgumentNull,
            Unknown
        }
        static ResultCode MaxOnMainDiag(decimal[,]matrix, out decimal max)
        {
            if (matrix!=null)
            {
                max = matrix[0, 0];
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i,i]>max)
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
        static int ReadMatrix(string prompt)
        {
            int[,] myArray = new int[3, 3];
        }
    }
}
