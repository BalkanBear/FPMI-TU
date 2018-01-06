using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_beers
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] beers = {"Zagorka", "Ariana", "Shumensko", "Astika", 
                             "Kamenitza", "Bolqrka", "Amstel"};
            Console.WriteLine("Unsorted: {0}", String.Join(", ", beers));
            Array.Sort(beers);
            Console.WriteLine("Sorted: {0}", String.Join(", ", beers));
            Console.ReadLine();
        }
    }
}
