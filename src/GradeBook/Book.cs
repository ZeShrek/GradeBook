using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(char letter)
        {

            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                case 'E':
                    AddGrade(50);
                    break;

                default:
                    AddGrade(0);
                    break;

            }
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }

        }

        public event GradeAddedDelegate GradeAdded;

        public Statistics GetStatistics()
        {

            var result = new Statistics();

            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            for (var index = 0; index < grades.Count; index++)
            {
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
            }

            result.Average = result.Average / grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.LetterGrade = 'A';
                    break;

                case var d when d >= 80.0:
                    result.LetterGrade = 'B';
                    break;

                case var d when d >= 70.0:
                    result.LetterGrade = 'C';
                    break;

                case var d when d >= 60.0:
                    result.LetterGrade = 'D';
                    break;

                case var d when d >= 50.0:
                    result.LetterGrade = 'E';
                    break;

                default:
                    result.LetterGrade = 'F';
                    break;
            }

            return result;
        }

        //List<double> grades = new List<double>(); //one way of doing it
        private List<double> grades;

        public string Name { get; set; }

        public const string CATEGORY = "Math";
    }
}