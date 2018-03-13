using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Bubble_search
{
    class BubbleSrch
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter count of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            var rnd = new Random();
            Console.WriteLine("Unsorted array is: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 101);
                Console.Write(a[i] + " ");
            }
            Console.ReadLine();
            //int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; ++j)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(ref a[j], ref a[j + 1]);
                        //temp = a[j + 1];
                        //a[j + 1] = a[j];
                        //a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadLine();
                        
                    
                    
                
                
                
                    
            
        }
    }
}
