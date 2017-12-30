using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Buyers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter demand: ");
            decimal demand0 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter demand unit: ");
            decimal demandunit = decimal.Parse(Console.ReadLine());
            Console.Write("Enter initial cost: ");
            decimal initialcost = decimal.Parse(Console.ReadLine());
            Console.Write("Enter cost unit: ");
            decimal costunit = decimal.Parse(Console.ReadLine());
            decimal a = -demandunit;
            decimal b = costunit * demandunit + demand0;
            decimal c = -costunit * demand0 - initialcost;
            decimal priceunit = (-(b / (2 * a)));
            decimal profit = a * priceunit * priceunit + b * priceunit + c;
            Console.WriteLine("Priceunit is: {0}", priceunit);
            Console.WriteLine("Max profit is: {0}", profit);
        }
    }
}
