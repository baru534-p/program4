using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program8
    {
        static void Main()
        {
            double celsius, kelvin, fahrenheit;

            Console.WriteLine("Enter the amount of Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            // Convert Celsius to Kelvin
            kelvin = celsius + 273.15;

            // Convert Celsius to Fahrenheit
            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");
            Console.ReadLine();
        }
    }
}

