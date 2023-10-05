using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            swapNos(n1, n2);


        }
        static void swapNos(int n1, int n2)
        {
            int temp = n1;
            n1 = n2;n2 = temp;
            Console.WriteLine($"Now the value of n1={n1}");
            Console.WriteLine($"Now the value of n2={n2}");
            Console.ReadLine();
        }
    }
}
