using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizingLists
{
    class ResList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string consoleline = Console.ReadLine();
            int n = int.Parse(consoleline);

            string lineBreak = new string('-', 20);

            for (int i = 0; i < n + 1; i++)
            {
                var capacity = list.Capacity;
                var count = list.Count;
                Console.WriteLine("Total capacity of the list: {0}\nused:{1}\n{2}",
                   capacity, count, lineBreak );
                list.Add(i);
            }
        }
    }
}
