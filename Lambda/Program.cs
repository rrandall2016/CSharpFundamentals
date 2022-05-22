using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    //Lambda Expressions

    //You use a lambda expression to create an anonymous function

    //Use the lambda declaration operator => to separate the lambda's parameter list from its body.
    //You specify input parameters (if any) on the left side of the lambda operator and
    //an expression or a statement block on the other side.

    //https://www.tutorialsteacher.com/linq/linq-lambda-expression

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int ExpressionBodiedMethod() => 10;
    }
    class Program
    {
        delegate bool IsTeenAger(Student stud);
        static void Main(string[] args)
        {
            //Anonymous function to lambda

            //IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

            //Thus, we got the lambda expression: s => s.Age > 12 && s.Age < 20 where s is a parameter, => is the lambda operator and
            //s.Age > 12 && s.Age < 20 is the body expression:
            IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;

            

            Student stud = new Student() { Age = 25 };
            Student stud2 = new Student() { Age = 15 };

            Console.WriteLine(isTeenAger(stud));
            Console.WriteLine(isTeenAger(stud2));


            int[] numbers = { 5, 10, 15, 20, 25, 30 };

            var result = numbers.Where(n => n >= 15 && n <= 25);

           Console.WriteLine("Numbers being >= 15 and <= 25:");
            foreach (var number in result)
                Console.WriteLine(number);

            string[] warmCountries = { "Turkey", "Italy", "Spain", "Saudi Arabia", "Etiobia" };
            string[] europeanCountries = { "Denmark", "Germany", "Italy", "Portugal", "Spain" };

            var result10 = warmCountries.Join(europeanCountries, warm => warm, european => european, (warm, european) => warm);

            Console.WriteLine("Joined countries which are both warm and Europan:");
            foreach (var country in result10) // Note: result is an anomymous type, thus must use a var to iterate.
                Console.WriteLine(country); 
            
            int[] numbers2 = { 1, 3, 5, 6, 7, 8 };

            //Example if not a lambda

            //bool hasEvenNumber = Array.Exists(numbers, IsEven);
            //public static bool IsEven(int num)
            //{
            //    return num % 2 == 0;
            //}

            bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0);

            bool hasBigDozen = Array.Exists(numbers, (int num) =>
            {
                bool isDozenMultiple = num % 12 == 0;
                bool greaterThan20 = num > 20;
                return isDozenMultiple && greaterThan20;
            });

            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result3 = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result3);

            int[] numbers3 = { 1, 3, 5, 6, 7, 8 };

            var testingLambda = numbers3.Sum(n => n * 2);
            //Aggregate: Performs a specified operation to each element in a collection, while carrying the result forward.
            var testingLambda2 = numbers3.Aggregate((a, b) => a * b);

  
            //sum
            Console.WriteLine(testingLambda);

            List<Student> details = new List<Student>
            {
                new Student{Id = 10, Name = "test", Age = 13},
                new Student{Id = 11, Name = "test2", Age = 48},
                new Student{Id = 12, Name = "teste", Age = 37},
            };
            var newDetails = details.OrderBy(x => x.Age);
            foreach(var student in details)
            {
                Console.WriteLine(student.Name);
            }


        }
    }
}
