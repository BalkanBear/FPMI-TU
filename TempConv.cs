﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
    class TempConv
    {
        static double FahrenheitToCelsius(double degrees)
        {
            double celsius = (degrees - 32) * 5 / 9;
            return celsius;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your body temperature in Fahrenheit degrees: ");
            double temperature = double.Parse(Console.ReadLine());

            temperature = FahrenheitToCelsius(temperature);

            Console.WriteLine("Your body temperature in Celsius degrees is {0}.", temperature);
            if (temperature >= 37 )
            {
                Console.WriteLine("You are ill!");
            }
        }
    }
}
