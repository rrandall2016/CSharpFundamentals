using System;
using System.Collections.Generic;

namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            //Side Note
            //Reference type is when you use a class

            //Interface type which means can be anything implement by interface
            IBook book = new InMemoryBook("Randy's Grade Book");

            book.GradeAdded += OnGradeAdded;

            //First part to write Enter a grade
            EnterGrades(book);

            var stats = book.GetStatistics();
            
            Console.WriteLine($"For book named {book.Name}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The average is: {stats.Average}");
            Console.WriteLine($"The average is grade: {stats.Letter}");


        }
        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Grade Added");
        }
        private static void EnterGrades(IBook book)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a grade or q for quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
        }
    }
}
