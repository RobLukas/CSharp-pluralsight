using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassesNoCore
{
    public class GradeBook
    {
        private List<float> grades;
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (_name != value && NameChanged != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }
                _name = value;
            }
        }

        public event NameChangedDegated NameChanged;

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
        public void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }
    }
}