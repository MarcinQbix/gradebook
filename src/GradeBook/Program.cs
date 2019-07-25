using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Marcin's GradeBook");

        while(true){
            Console.WriteLine("Enter a grade or 'q' to quit");
        var input = Console.ReadLine();
        if(input == "q"){
       break;
        }
         var grade = double.Parse(input);
         book.AddGrade(grade);
        }
        var stats = book.GetStatistics();


        Console.WriteLine($"The Highest Grade is {stats.High}");
     Console.WriteLine($"The Lowest Grade is {stats.Low}");
      Console.WriteLine($"The AVarage Grade is {stats.Avarage:N1}");
      System.Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
