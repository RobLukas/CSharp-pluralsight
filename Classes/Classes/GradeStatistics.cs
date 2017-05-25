using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class GradeStatistics
    {
        public float AverageGrade;
        public float MinGrade;
        public float MaxGrade;

        public GradeStatistics()
        {
            MaxGrade = 0;
            MinGrade = float.MaxValue;
        }
    }
}