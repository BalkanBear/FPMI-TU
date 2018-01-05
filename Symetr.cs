using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symetric
{
    class Symetr
    {
        static void Main(string[] args)
        {
            Console.Write("Number of elements= ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}]= ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            bool isSymmetric = true;
            for (int i = 0; i < array.Length/2; i++)
            {
                if (array[i] != array[n-i-1])
                {
                    isSymmetric = false;
                    break;
                }

            }
            Console.WriteLine("Symmetric?---> {0}", isSymmetric);
        }
    }
}
