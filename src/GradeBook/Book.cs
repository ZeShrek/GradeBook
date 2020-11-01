using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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

        public Statistics GetStatistics()
        {

            var result = new Statistics();

            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach (double grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average = result.Average / grades.Count;

            return result;
        }

        public void ShowStatistics()
        {

        }

        //List<double> grades = new List<double>(); //one way of doing it
        private List<double> grades;
        private string name;
    }
}