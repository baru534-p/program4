using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x value");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter z value");
            int z = Convert.ToInt32(Console.ReadLine());
            int output1 = (x + y) * z;
            int output2 = x * y + y * z;
            Console.WriteLine($"Result of specified numbers {x},{y} and{z},(x+y)*z is {output1} and x*y+y*z is {output2}");
            Console.ReadLine();
            

        }
    }
}
