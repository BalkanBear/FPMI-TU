using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Sw
    {
        static void Main(string[] args)
        {
            int a = ReadInt("Въведете a: ");
            int b = ReadInt("Въведете b: ");
            Swap(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
        static void Swap (ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static int ReadInt(string prompt)
        {
            int a;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Въведете валидно цяло число: ");
            }

            return a;

        }
    }
}
