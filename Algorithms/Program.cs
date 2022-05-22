using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        //Check for highest three elements from product
        public static int maxProduct(int[] arr, int n)
        {

            // if size is less than
            // 3, no triplet exists
            if (n < 3)
                return -1;

            // will contain max product
            int max_product = int.MinValue;

            for (int i = 0; i < n - 2; i++)
            for (int j = i + 1; j < n - 1; j++)
            for (int k = j + 1; k < n; k++)
                max_product = Math.Max(max_product, arr[i] * arr[j] * arr[k]);

            return max_product;
        }

        //Duplicate check using LINQ
        //The Distinct extension method removes any duplicates,
        //and Count gets the size of the result set. If they differ at all, then there are some duplicates in the list.
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length != nums.Distinct().Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int testing(int[] arr)
        {
            int max = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                max = max * arr[i];
            }

            if (max == 0)
            {
                return 0;
            }
            else if (max >= 1)
            {
                return 1;
            }

            return -1;
        }

        public static int testing2(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    return 0;
                if (arr[i] < 0)
                {
                    count++;
                }
            }
            // if ? this : else this
            return count % 2 == 0 ? 1 : -1;
        }
        //Roman numeral to integer
        public static int RomanToInt(string s)
        {
            //Add unique keys 
            Dictionary<string, int> RomanToInt = new();
            RomanToInt.Add("M", 1000);
            RomanToInt.Add("D", 500);
            RomanToInt.Add("C", 100);
            RomanToInt.Add("L", 50);
            RomanToInt.Add("X", 10);
            RomanToInt.Add("V", 5);
            RomanToInt.Add("I", 1);
            RomanToInt.Add("IV", 4);
            RomanToInt.Add("IX", 9);
            RomanToInt.Add("XL", 40);
            RomanToInt.Add("XC", 90);
            RomanToInt.Add("CD", 400);
            RomanToInt.Add("CM", 900);

            int total = 0;
            int i = 0;
            while (i < s.Length)
            {
              //Check there is a pair
                if (i < s.Length - 1)
                {
                    //Length not index for substring, take pair
                    string doubleSymbol = s.Substring(i, 2);
                    //Check if pair is in the key
                    if (RomanToInt.ContainsKey(doubleSymbol))
                    {
                        //Add total from Hashtable/Dictionary
                        total += RomanToInt[doubleSymbol];
                        i += 2;
                        //skip over the bottom portion part of the loop, goes to while condition
                        continue;
                    }
                }
                //Otherwise
                string singleSymbol = s.Substring(i, 1);
                total += RomanToInt[singleSymbol];
                i++;
            }
            return total;
        }
        public static int Solution(string roman)
        {
            int total = 0;
            (int Value, int Rank) lastValue = (0, 0);
            foreach (char symbol in roman)
            {
                (int Value, int Rank) value = SymbolValue[symbol];
                if (value.Rank >= lastValue.Rank)
                    total += value.Value <= lastValue.Value ? value.Value : value.Value - lastValue.Value * 2;
                else
                    total += value.Value;

                lastValue = value;
            }

            return total;
        }

        static Dictionary<char, (int Value, int Rank)> SymbolValue
            = new(){
                { 'I', (1,    1)},
                { 'V', (5,    1)},
                { 'X', (10,   2)},
                { 'L', (50,   2)},
                { 'C', (100,  3)},
                { 'D', (500,  3)},
                { 'M', (1000, 4)},
            };
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 3, 1, 2};
            int[] arr3 = new int[] {1, 2, 3};
            int[] arr2 = new int[] {1, 2, 3, 1};
            int[] nums2 = new int[] {-1, 0, 0, 1, 1, 1, 2, 2, 2, 3, 4, 5};
            int[] testing2 = new int[] {-1, -3, 2, 1, 2, 6, 4, 9, -1};

            Console.WriteLine(RomanToInt("MCMXCIV"));
            Console.WriteLine(Solution("CMXCIV"));


          
        }
    }
}

