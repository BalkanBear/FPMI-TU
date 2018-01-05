using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class JagArr
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 4, 113, 2, 3, 15, 14, 11, 20, 27, 28, 22, 24 };
            int[] sizes = new int[3];
            int[] offsets = new int[3];

            foreach (int number in numbers)
            {
                int reminder = number % 3;
                sizes[reminder]++;
            }

            int[][] numbersByReminder = new int[3][] {
                new int[sizes[0]], new int[sizes[1]], new int[sizes[2]]
            };

            foreach (var number in numbers)
            {
                int reminder = number % 3;
                int index = offsets[reminder];
                numbersByReminder[reminder][index] = number;
                offsets[reminder]++;
            }
            for (int row = 0; row < numbersByReminder.GetLength(0); row++)
            {
                foreach (var num in numbersByReminder[row])
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            } 
        }
    }
}
