using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program5
    {
        public class PS5
        {
            public static void Main(string[] args)
            {
                int number;

                Console.Write("Enter a digit: ");
                number = int.Parse(Console.ReadLine());

                // Using Console.Write
                Console.Write(number);
                Console.Write(" ");
                Console.Write(number);
                Console.Write(" ");
                Console.Write(number);
                Console.Write(" ");
                Console.WriteLine(number);
                Console.WriteLine("{0}{0}{0}{0}", number);

                // Using {0}
                Console.WriteLine("{0} {0} {0} {0}", number);
                Console.WriteLine("{0}{0}{0}{0}", number);
                Console.Read();
            }
        }
    }
}
