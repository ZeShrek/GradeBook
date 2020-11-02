using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Math Grades Book");


            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            };

            var stats = book.GetStatistics();

            //now print statistics
            Console.WriteLine($"The lowest grade is: {stats.Low:N2}");
            Console.WriteLine($"The higher grade is: {stats.High:N2}");
            Console.WriteLine($"Average: {stats.Average:N2}");
            Console.WriteLine($"The letter grade is: {stats.LetterGrade}");
        }
    }
}
