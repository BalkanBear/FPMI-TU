using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_number
{
    class Rand
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int value = r.Next(1, 101);
            int guess;
            int attempt = 0;
           

            do
            {
                guess = int.Parse(Console.ReadLine());
                if (value>guess)
                {
                    Console.WriteLine("Нагоре");
                }
                else if (value<guess)
                {
                    Console.WriteLine("Надолу");
                }
                ++attempt;
            }
            while (value != guess);
            Console.WriteLine("Познахте от {0} опит.", attempt);
        }
    }
}
