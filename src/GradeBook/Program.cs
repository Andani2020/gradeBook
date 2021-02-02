using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Andani's grade book");
            book.GradeAdded += OnGradeAdded;
           
            EnterGrades(book);
            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The Average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.letter}");

        }
        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Grade was Added");
        }
        private static void EnterGrades(IBook book)
        { 
            
            while (true)
            {
                
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }
    }
}
