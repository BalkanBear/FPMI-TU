using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitals
{
    class Collect
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Console.Write("Original array: ");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < array.Length; i+=2)
            {
                array[i] = -1;
            }
            Console.Write("Modified array: ");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
