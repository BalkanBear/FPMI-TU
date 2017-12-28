using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_projects
{
    class Kih
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int digit0 = number[0] - '0';
            int digit1 = number[1] - '0';
            int digit2 = number[2] - '0';

            Console.WriteLine("Цифра 0: {0}, Цифра 1: {1} Цифра 2: {2}", digit0, digit1, digit2);
            int sum = digit0 + digit1 + digit2;
            char bukva = (char)('A' + sum - 1);

            Console.WriteLine("Някой, чието име започва с буквата {0} си мисли за вас.", bukva);
        }
    }
}
