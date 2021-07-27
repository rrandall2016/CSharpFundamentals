using System;
using System.Collections.Generic;

namespace Generic_Collection_HashSet_Dictionary_No_Duplicates_
{
    class Program
    {

        public static void DisplaySet(HashSet<int> collection)
        {
            Console.Write("{");
            foreach (int i in collection)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
        static void Main(string[] args)
        {
            //HashSet<T>---
            //Set is a collection that contains no duplicate elements, and whose elements are in no particular order.

            //If order or element duplication is more important than performance for your application,
            //consider using the List<T> class together with the Sort method.

            //Hashset provides UnionWith,IntersectWith, and ExceptWith, etc operations. 

            HashSet<int> set = new();
            set.Add(1);
            set.Add(2);
            set.Add(2);//Won't change outut because no duplicates allowed 

            foreach(var item in set)
            {
                Console.WriteLine(item);
            }

            //
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                // Populate numbers with just even numbers.
                evenNumbers.Add(i * 2);

                // Populate oddNumbers with just odd numbers.
                oddNumbers.Add((i * 2) + 1);
            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);

            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);

            // Create a new HashSet populated with even numbers.
            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);


        }
    }
}
