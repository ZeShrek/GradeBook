using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade > 0)
            {
                grades.Add(grade);
            }

        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            double avarage;
            foreach (double number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            avarage = result / grades.Count;

            //now print statistics
            Console.WriteLine($"The result is: {result}");
            Console.WriteLine($"The lowest grade is: {lowGrade:N2}");
            Console.WriteLine($"The higher grade is: {highGrade:N2}");
            Console.WriteLine($"Average: {avarage:N2}");
        }

        //List<double> grades = new List<double>(); //one way of doing it
        private List<double> grades;
        private string name;
    }
}