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
            Console.Write("Enter N(N<20): ");
            int n = int.Parse(Console.ReadLine());
          
            for (int row = 1; row <=n; row++)
            {
                for (int col=row; col<=row+n-1;col++)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
            
        }
    }
}
