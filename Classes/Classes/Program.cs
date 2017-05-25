using System;
using static System.Console;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.AddGrade(20);
            book.AddGrade(40);
            book.AddGrade(140);
            book.AddGrade(10);

            
            GradeStatistics stats = book.ComputerStatistics();
            WriteLine(stats.AverageGrade);
            WriteLine(stats.MinGrade);
            WriteLine(stats.MaxGrade);
        }
    }
}