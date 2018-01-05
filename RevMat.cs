using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_matrix
{
    class RevMat
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int length = array.Length;
            int[] reversed = new int[length];
            for (int i = 0; i < length; i++)
            {
                reversed[length - i - 1] = array[i];
                
                
            }
            for (int i = 0; i < length; i++)
			{
                Console.WriteLine(reversed[i]);
			}
        }
    }
}
