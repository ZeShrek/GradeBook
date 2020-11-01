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

            book.ShowStatistics();
        }
    }
}
