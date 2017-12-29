using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our_number
{
    class Numb
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете вашето число: ");
            int a = int.Parse(Console.ReadLine());

            var r = new Random();
            int[] arr = new int[100];
            int d = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 101);
                if (a==arr[i])
                {
                    d++;
                }
                Console.WriteLine(arr[i]);

            }
            Console.WriteLine("Числото ти се повтори {0} пъти.", d);
        }
    }
}
