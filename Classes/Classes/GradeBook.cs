using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class GradeBook
    {
        private List<float> grades;

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputerStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (var grade in grades)
            {
                stats.MaxGrade = Math.Max(grade, stats.MaxGrade);
                stats.MinGrade = Math.Min(grade, stats.MinGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
    }
}