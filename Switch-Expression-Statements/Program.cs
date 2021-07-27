using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Switch_Expression_Statements
{
    //Switch Statements - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 1;
            //Each case statement defines a pattern that,
            //if it matches the match expression, causes its containing switch section to be executed.
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            //Example 2 Type Pattern
            int[] values = { 2, 4, 6, 8, 10 };
            ShowCollectionInformation(values);

            var names = new List<string>();
            names.AddRange(new string[] { "Adam", "Abigail", "Bertrand", "Bridgette" });
            ShowCollectionInformation(names);

            List<int> numbers = null;
            ShowCollectionInformation(numbers);
        }
        //The following example uses the type pattern to provide information about various kinds of collection types.
        //Type matching
        private static void ShowCollectionInformation(object coll)
        {
            switch (coll)
            {
                case Array arr:
                    Console.WriteLine($"An array with {arr.Length} elements.");
                    break;
                case IEnumerable<int> ieInt:
                    Console.WriteLine($"Average: {ieInt.Average(s => s)}");
                    break;
                case IList list:
                    Console.WriteLine($"{list.Count} items");
                    break;
                case IEnumerable ie:
                    string result = "";
                    foreach (var e in ie)
                        result += $"{e} ";
                    Console.WriteLine(result);
                    break;
                case null:
                    // Do nothing for a null.
                    break;
                default:
                    Console.WriteLine($"A instance of type {coll.GetType().Name}");
                    break;
            }
        }
    }
}
