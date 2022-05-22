using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    class Program
    {
        private static Dictionary<string, int> romanMappings = new Dictionary<string, int>()
        {
            { "MX̄", 9000 },
            { "X̄", 10000 },
            { "V̄MMM", 8000 },
            { "V̄MM", 7000 },
            { "V̄M", 6000 },
            { "MV̄", 4000 },
            { "V̄", 5000 },
            { "MMM", 3000 },
            { "MM", 2000 },
            { "CM", 900 },
            { "M", 1000 },
            { "DCCC", 800 },
            { "DCC", 700 },
            { "DC", 600 },
            { "CD", 400 },
            { "D", 500 },
            { "CCC", 300 },
            { "CC", 200 },
            { "XC", 90 },
            { "C", 100 },
            { "LXXX", 80 },
            { "LXX", 70 },
            { "LX", 60 },
            { "XL", 40 },
            { "L", 50 },
            { "XXX", 30 },
            { "XX", 20 },
            { "IX", 9 },
            { "X", 10 },
            { "VIII", 8 },
            { "VII", 7 },
            { "VI", 6 },
            { "IV", 4 },
            { "V", 5 },
            { "III", 3 },
            { "II", 2 },
            { "I", 1 },
        };

        public static int RomanToArabic(string roman)
        {
            var result = 0;

            //For each item in string, if the string contains the key
            foreach (var kvp in romanMappings)
            {
                if (roman.Contains(kvp.Key))
                {
                    //add value to the result
                    result += kvp.Value;
                    //Replace the 
                    roman = roman.Replace(kvp.Key, "");
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToArabic("MCMLXXXI"));
            Console.WriteLine(RomanToArabic("MX̄DCCLI"));
            Console.WriteLine(RomanToArabic("MMXIX"));
            Console.WriteLine(RomanToArabic("MCMXCIV"));
        }
    }

}
