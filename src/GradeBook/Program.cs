using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Marcin's GradeBook");
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);
            var stats = book.GetStatistics();

            System.Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The Highest Grade is {stats.High}");
            Console.WriteLine($"The Lowest Grade is {stats.Low}");
            Console.WriteLine($"The AVarage Grade is {stats.Avarage:N1}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");
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
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    System.Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e){
            System.Console.WriteLine("A Grade was added");
        }
    
    }
}
