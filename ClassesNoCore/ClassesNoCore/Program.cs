using System;
using static System.Console;
using System.Speech.Synthesis;


namespace ClassesNoCore
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            //GradeBook g1 = new GradeBook();
            //GradeBook g2 = g1;

            try
            {
                WriteLine("Enter a name");
                book.Name = ReadLine();
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                WriteLine("Something went wrong!");
            }


            //book.NameChanged += OnNameChanged;

            //book.Name = "Rob's Grade Book";
            //book.Name = "Grade Book";

            //SpeechSynthesizer speech = new SpeechSynthesizer();
            //speech.Speak("Hello World");

            book.AddGrade(20);
            book.AddGrade(40);
            book.AddGrade(140);
            book.AddGrade(10);
            book.WriteGrades(Out);

            GradeStatistics stats = book.ComputerStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.MaxGrade);
            WriteResult("Lowest", stats.MinGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }
        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }
        static void WriteResult(string description, string result)
        {
            WriteLine($"{description}: { result}");
        }
        static void WriteResult(string description, float result)
        {
            WriteLine($"{description}: { result:F2}");
        }
    }
}