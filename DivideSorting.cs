using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Sorting
{
    public class SortingArrays
    {
        private class NumbersComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return (x % 5).CompareTo(y % 5);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 6, 10, 11 };
            Array.Sort(numbers, new NumbersComparer());
            Console.WriteLine("Numbers sorted by modul 5: ");
            foreach (var s in numbers)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Array.Sort(numbers, (x,y) => (y % 6).CompareTo (x % 6));
            Console.WriteLine("Numbers sorted descending: ");
            foreach (var s in numbers)
            {
                Console.WriteLine(s);
            }
        }
    }
}
