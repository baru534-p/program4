using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

                Console.WriteLine("Enter marks in three subjects:");

                Console.Write("Subject 1: ");
                double subject1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Subject 2: ");
                double subject2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Subject 3: ");
                double subject3 = Convert.ToDouble(Console.ReadLine());

                // Calculate total marks
                double totalMarks = subject1 + subject2 + subject3;

                // Calculate percentage
                double percentage = (totalMarks / 300) * 100;

                // Determine the grade based on percentage
                string grade;

                if (percentage >= 60)
                {
                    grade = "First";
                }
                else if (percentage >= 45)
                {
                    grade = "Second";
                }
                else if (percentage >= 35)
                {
                    grade = "Third";
                }
                else
                {
                    grade = "Fail";
                }

                Console.WriteLine($"Total Marks: {totalMarks}");
                Console.WriteLine($"Percentage: {percentage:F2}%");
                Console.WriteLine($"Grade: {grade}");

                Console.ReadLine();
            
        }
    }
}
