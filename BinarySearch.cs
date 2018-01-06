using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] beers = {"Zagorka", "Ariana", "Shumensko", "Astika", 
                             "Kamenitza", "Bolqrka", "Amstel"};
            Array.Sort(beers);
            string target = "Astika";
            int index = Array.BinarySearch(beers, target);
            Console.WriteLine("{0} is found at index {1}.", target, index);

            target = "Heineken";
            index = Array.BinarySearch(beers, target);
            Console.WriteLine("{0} is not found(index={1}).", target, index);
        }
    }
}
