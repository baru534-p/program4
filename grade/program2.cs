using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program2
    {
        static void main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int n3 = Convert.ToInt32(Console.ReadLine());
            int output = n1 * n2 * n3;
            Console.WriteLine($"n1*n2*n3 {output}");
            Console.ReadLine();
;        }
    }
}
    

