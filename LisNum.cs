using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNumbers
{
    class LisNum
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }
            numbers[0] = 5;
            numbers.Remove(7);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
