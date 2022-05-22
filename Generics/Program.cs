using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Generics
{

    class Program
    {
        static void NewList(List<int> newArray)
        {
            List<int> newArray2 = new();
            foreach (var itemElement in newArray)
            {
                newArray2.Add((itemElement + 2) * 5);
            }
            foreach (var item2 in newArray2)
            {
                Console.WriteLine(item2);
            }
        }
        //Employee Object for demo
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Employee()
            {
                //Hard coded for demo
                Id = 1;
                Name = "Employee Demo";
            }
            public Employee(int id, string name)
            {
                
                Id = id;
                Name = name;
            }

        }
        static void Main(string[] args)
        {
            //Generic Collections-------

            //List<T>---
            //Big O = O(n) insert/remove/contains, O(1) add/item[index]

            //--
            //Notes
            //Vector from C++
            //ArrayList container 
            //Properties include Capacity,Count,Item
            //Count is from LINQ
            //Adjusts size on own
            //Continues to double capacity when triggered
            //Really good for when you don't know how many items you are going to need to store
            //--


            //Create Lists
            List<int> VectorStyle = new List<int>();
            List<int> newList = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                VectorStyle.Add(i);
            }
            //Assign index but only after size has been initiated 
            VectorStyle[0] = 10;
            //Make copy

            for (int i = 0; i < 6; i++)
            {
                newList.Add(VectorStyle[i]);
            }

            //Finds the duplicates between lists 
            var duplicates = VectorStyle.Intersect(newList).ToList();
            
            //Reverse numbers 
            VectorStyle.Reverse();
            //Count amount of elements
            VectorStyle.Count();

            //Remove at an index
            newList.RemoveAt(3);

            //Bag List
            List<char> bag = new List<char>();
            //Add chars
            bag.Add('A');
            bag.Add('A');
            bag.Add('A');
            bag.Add('B');

            //True or false contains
            Console.WriteLine(bag.Contains('A'));

            //Count occurences of an element 
            var count1 = bag.Where(x => x == 'A').Count();

            //Create List and initialize two Employees with different constructors
            List<Employee> EmployeeList = new List<Employee>()
            {
                //Different ways to create object 
                new Employee{},
                new Employee(4, "Test"),
                new Employee{Name = "TestingEmployee", Id = 5 }

            };
            //Use add feature, can only take type you told it to
            EmployeeList.Add(new Employee { Name = "Employee Demo", Id = 3 });
            
            //Print employee
            foreach(var employee in EmployeeList)
            {
                Console.WriteLine(employee.Name + " " + employee.Id);
            }

            //If need everything inside the queue, convert to array. Makes a copy
            var asArray = bag.ToArray();



            List<int> mylist = new List<int>
                (new int[] { 1, 2, 3, 4 }
                );

            NewList(mylist);


            List<Employee> Practice = new()
            {
                new Employee {Id = 11, Name = "Testing"},
                new Employee(12, "Testing2"),
                new Employee(13, "Testing3")
            };

            //Exercise 1
            List<string> names = new();
            names.Add("Brett");
            names.Add("Ash");
            names.Add("Poke");
            names.Add("Yup");
            
            Console.WriteLine(names[0]);
            int counting = names.Count();

            names.Remove("Brett");
            Console.WriteLine(names[0]);

            names[2] = "Changed";


        }
    }
}
