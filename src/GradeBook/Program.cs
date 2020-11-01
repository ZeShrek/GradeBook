using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Math Grades Book");
            book.AddGrade(5.3);
            book.AddGrade(6.9);
            book.AddGrade(12.9);

            var stats = book.GetStatistics();

            //now print statistics
            Console.WriteLine($"The lowest grade is: {stats.Low:N2}");
            Console.WriteLine($"The higher grade is: {stats.High:N2}");
            Console.WriteLine($"Average: {stats.Average:N2}");
        }
    }
}
