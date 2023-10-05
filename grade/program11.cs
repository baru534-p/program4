using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class program11
    {
         public static void Main()
         {
            Console.Write("Enter the number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int years = days / 365;     // Calculate years
            int remainingDays = days % 365; // Calculate remaining days

            int weeks = remainingDays / 7;   // Calculate weeks
            int remainingDaysInWeeks = remainingDays % 7; // Calculate remaining days

            Console.WriteLine($"{days} days is equivalent to:");
            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {remainingDaysInWeeks}");

            Console.ReadLine();
         }
    }
}

