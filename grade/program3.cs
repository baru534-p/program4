using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program3
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("input the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            double add = num1 + num2;
            Console.WriteLine($"{num1}+{num2}={add}");
            double sub = num1 - num2;
            Console.WriteLine($"{num1}-{num2}={sub}");
            double mul = num1 * num2;
            Console.WriteLine($"{num1}*{num2}={mul}");
            double div = num1 / num2;
            Console.WriteLine($"{num1}/{num2}={div}");
            double mod = num1 % num2;
            Console.WriteLine($"{num1}%{num2}={mod}");
            Console.ReadLine();



        }
    }
}
    

