using System;

namespace Atesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 5;
            //for (int i = number; i < 10000; i = i + number)
            //{
                
            //    Console.WriteLine(i);
            //}

            string Testing = "Sally Mary Jones";

            string first = Testing.Substring(0,1);

            string fullName = "Adrian Rules jones";
            var names = fullName.Split(' ');

            //string firstName = names[0];
            //string midName = names[1];
            //string lastName = names[2];

            Console.WriteLine(first);
            


        }
    }
}
