using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palin
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.Write("Дума: ");
                string s = Console.ReadLine();
                bool isPalindrome = true;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != s[s.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }

                }
                if (isPalindrome)
                {
                    Console.WriteLine("Палиндром!");
                }
                else
                    Console.WriteLine("Думата НЕ е палиндром!");
                break;
            }
            Console.WriteLine("Довиждане!");
        }
    }
}
