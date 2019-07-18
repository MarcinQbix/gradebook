using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Marcin's GradeBook");
         book.AddGrade(26.2);
            book.AddGrade(23.1);
            book.AddGrade(90.2);
            book.AddGrade(89.1);
        var stats = book.GetStatistics();

        Console.WriteLine($"The Highest Grade is {stats.High}");
     Console.WriteLine($"The Lowest Grade is {stats.Low}");
      Console.WriteLine($"The AVarage Grade is {stats.Avarage:N1}");
        }
    }
}
