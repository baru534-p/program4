using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double max = Math.Max(num1, num2);
            double min = Math.Min(num1, num2);

            Console.WriteLine($"Maximum number: {max}");
            Console.WriteLine($"Minimum number: {min}");
            Console.ReadLine();
        }
    }
}
    

