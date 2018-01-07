using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Array
{
    class MethArr
    {
        static void PrintArray (int[] arr)
        {
            foreach (var value in arr)
            {
                Console.Write(value);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void Example (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + 1;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5 };
            PrintArray(arr);
            Example(arr);
            PrintArray(arr);
        }
    }
}
