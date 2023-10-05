using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                int tripleSum = 3 * sum;
                Console.WriteLine($"The values are equal, so the triple of their sum is {tripleSum}");
            }
            else
            {
                Console.WriteLine($"The sum of the two integers is {sum}");
            }
        }
    }
}

