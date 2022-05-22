using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Arrays
{
    class Program
    {
        public bool IsValue(int[] values1, int[] values2)
        {
            for (int i = 0; i < values1.Length; i++)
            {
                for (int j = 0; j < values2.Length;)
                {
                    if (values1[i] == values2[j])
                    {
                        return true;
                        
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            //Arrays are objects and require new keyword
            int[] listOfNumbers = { 1, 2, 3, 4 };

            //Add at this index
            int certainIndexSum = listOfNumbers[0] + listOfNumbers[1] + listOfNumbers[2];

            //Different ways to create array
            int[] c1 = new int[12];

            int[] c2;
            c2 = new int[12];

            int[] array = new int[5];

            //Console.WriteLine($"{"Index"}{"Value",8}");

            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            foreach(var day in weekDays2)
            {
                //Console.WriteLine(day);
            }
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 3, 2, 1 };

            //Console.WriteLine(arr1.SequenceEqual(arr2)); // false
            //Console.WriteLine(arr1.Reverse().SequenceEqual(arr2)); // true

            int[] values3 = { 1, 2, 3, 4, 2 };
            int[] values4 = { 1, 2, 4, 3 };
            var result = values3.Except(values4);
            if (result.Count() == 0)
            {
                //They are the same
                Console.WriteLine("Yes!");
            }
            else
            {
                //They are different
                Console.WriteLine("No!");
            }

            int[] values1 = { 5, 3, 7, 8,};
            int[] values2 = { 1, 2, 4, 3 };

            Program testing = new Program();
            var printThis = testing.IsValue(values1, values2);

            //Console.WriteLine(printThis);
            string cat = "zacat";

            if(cat[0] == 'c')
            {
                if (cat[1] == 'a')
                {
                    if (cat[2] == 't')
                    {
                        Console.WriteLine("true");
                    }
                    else if (cat[2] != 't')
                    {
                        Console.WriteLine("false");
                        //cout << "false;
                    }
                }
                else if (cat[1] != 'a')
                {
                    Console.WriteLine("false");
                    //cout << "false;
                }
            }
            else if (cat[1] == 'c')
            {
                if (cat[2] == 'a')
                {
                    if (cat[3] == 't')
                    {
                        Console.WriteLine("true");
                    }
                    else if (cat[3] != 't')
                    {
                        Console.WriteLine("false");
                        //cout << "false;
                    }
                }
                else if (cat[2] != 'a')
                {
                    Console.WriteLine("false");
                    //cout << "false;
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
