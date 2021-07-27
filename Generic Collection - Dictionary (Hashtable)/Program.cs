using System;
using System.Collections.Generic;

namespace Generic_Collection___Dictionary__Hashtable_
{
    //Dictionary<T>
    //No duplicates allowed for unique key
    /// <summary>
    /// Create for insert and removal, more memory usage than SortedList, SortedList is better for looping all item
    /// If need look ups by key, SortedDictionary is better
    /// </summary>

     
    class Program
    {
        public class Employee
        {
            public int id { get; set; }
            public bool isEmployed { get; set; }
        }
        public class Employee2
        {
            public string Name { get; set; }
            public bool isEmployed { get; set; }
        }
        static void Main(string[] args)
        {
            //Dictionary with single Employee objects
            Dictionary<string, Employee> employeesByName = new();

            employeesByName.Add("A", new Employee { id = 1, isEmployed = true });
            employeesByName.Add("B", new Employee { id = 2, isEmployed = true });
            employeesByName.Add("C", new Employee { id = 3, isEmployed = false });
            employeesByName.Add("D", new Employee { id = 4, isEmployed = false });
            employeesByName.Add("E", new Employee { id = 5, isEmployed = false });


            var koga = employeesByName["C"];
            if (employeesByName["A"].isEmployed == true)
            {
                Console.WriteLine("Is A employed? : Is employed");
            }

            //Console.WriteLine(koga.isEmployed);

            //Can access key and values
            Console.WriteLine("Print out all Name and bool of isEmployed in list : ");
            foreach (var item in employeesByName)
            {
                Console.WriteLine($"{item.Key} : {item.Value.isEmployed}");
            }

            //Dictionary with List(vector) of Employee objects
            Dictionary<string, List<Employee2>> employeesByList = new();

            // String key, add new List of Employee2
            employeesByList.Add("IT Department", new List<Employee2>() { new Employee2 { Name = "IT Person", isEmployed = true } }) ;
            employeesByList.Add("HR", new List<Employee2>() { new Employee2 { Name = "HR Person", isEmployed = true } });
            employeesByList.Add("Management", new List<Employee2>() { new Employee2 { Name = "Management Person", isEmployed = true } });

            //Find List called IT Deparment, add a new Employee2
            employeesByList["IT Department"].Add(new Employee2 { Name = "IT Person2" });

            Console.WriteLine("Print all employees in all lists: ");
            //foreach list, print all the employees
            foreach(var item in employeesByList)
            {
                foreach (var employee in item.Value)
                {
                    Console.WriteLine(employee.Name);
                }
            }

            //Sorting a Dictionary of List<Employee>
            //The SortedDictionary<TKey, TValue> generic class is a binary search tree with O(log n) retrieval,
            //where n is the number of elements in the dictionary

            //Dictionary with List(vector) of Employee objects
            SortedDictionary<string, List<Employee2>> employeesSorted = new();

            // String key, add new List of Employee2
            employeesSorted.Add("IT Department", new List<Employee2>() { new Employee2 { Name = "IT Person", isEmployed = true } });
            employeesSorted.Add("HR", new List<Employee2>() { new Employee2 { Name = "HR Person", isEmployed = true } });
            employeesSorted.Add("Management", new List<Employee2>() { new Employee2 { Name = "Management Person", isEmployed = true } });

            //Add three employees to list
            employeesSorted["Management"].Add( new Employee2 { Name = "Management PersonC", isEmployed = true });
            employeesSorted["Management"].Add( new Employee2 { Name = "Management PersonB", isEmployed = true });
            employeesSorted["Management"].Add( new Employee2 { Name = "Management PersonA", isEmployed = true });

            //Print out the sorted departments
            //Dictionary 
            Console.WriteLine("Sorted Dictionary Department List-------------");
            foreach (var item in employeesSorted)
            {
                
                    Console.WriteLine(item.Key);
                
            }
        }

       
    }
}
