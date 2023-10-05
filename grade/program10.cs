using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program10
    {
       public  static void Main(string[] args)
       {
            Console.WriteLine("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double absoluteDifference = Math.Abs(number1 - number2);

            if (number1 > number2)
            {
                double result = 2 * absoluteDifference;
                Console.WriteLine("The result is: " + result);
            }
            else
            {
                Console.WriteLine("The result is: " + absoluteDifference);
                Console.ReadLine();
            }
        }
    }
}

