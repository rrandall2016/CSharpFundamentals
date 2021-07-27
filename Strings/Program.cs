using System;
using System.Linq;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings
            //Visit Time Corey String Manipluation Techniques
            https://www.youtube.com/watch?v=ioi__WRETk4&ab_channel=IAmTimCorey

            //Does string contain
            string example = "x@yahoo.com";
            Console.WriteLine($"Does string contain yahoo.com?: {example.Contains("yahoo.com")}");

            //All string to uppercase, lowercase
            string exampleUpperCase = example.ToUpper();
            string exampleLowerCase = example.ToLower();

            //Replace yahoo.com
            string exampleReplace = example.Replace("yahoo.com", "gmail.com");
            Console.WriteLine(exampleReplace);

            //Find index at @, and make the string start there 
            int findIndex = exampleReplace.IndexOf('@');
            string SliceAllBeforeAtSymbol = exampleReplace.Substring(findIndex);
            Console.WriteLine(SliceAllBeforeAtSymbol);

            //Find length of string
            int exampleLength = example.Length;
            Console.WriteLine($"String length: {exampleLength}");

            //Random number to show different ways for output 
            string a = "A different way to use string variables";
            Console.WriteLine($"First way: {a}");
            Console.WriteLine("Second way: " + a);

            //Reverse string
            //Have to convert to char array for .Reverse to work
            string reverse = "ydnaR";
            char[] charArrayConversion = reverse.ToArray();
            Array.Reverse(charArrayConversion);
            Console.WriteLine(charArrayConversion);

            //Escape characters 
            //Now quotes are visible 
            string txt = "We are the so-called \"Vikings\" from the north.";
            string txt2 = "It\'s alright.";
            string txt3 = "The character \\ is called backslash.";

            //Useful escape characters
            Console.WriteLine("1.\n2.\n3.");

            //Concating strings 
            string newString = "y";

            newString += SliceAllBeforeAtSymbol;
            Console.WriteLine(newString);

            //Initialize string
            string[] StringOne = { "one", "two", "three" };
            string[] StringTwo = new string[3];

            //Multi-D Array of strings
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };


        }
    }
}
