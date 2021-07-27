using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        //Lanugage Integrated Query (LINQ)
        //Used for object data, xml, relational

        //Works with inMemory and DB
        //All LINQ queries work on IEnumberable<T> 
        //
        //Lambda expression = short, concise, for defining a method I can invoke

        //Method vs Query syntax 

        //Other Examples
        //https://linqsamples.com/linq-to-objects/ordering/OrderBy-numbers



        static void Main(string[] args)
        {
            //Array of Employee
            Employee[] developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Scott"},
                new Employee {Id = 2, Name = "Chris"},
                new Employee {Id = 3, Name = "Dave"}
            };
            List<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 4, Name = "Alex"}
            };
            
            //For every employee, keep employee with startswith S and print
            //Metho
            foreach(var employee in developers.Where(
                 e => e.Name.StartsWith("S")
            ))
            {
                Console.WriteLine(employee.Name);
            }
            //Method vs Query
            var query = developers.Where(e => e.Name.Length == 5)
                .OrderBy(e => e.Name);
                

            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer;

            foreach(var employee in query2) 
            {
                Console.WriteLine(employee.Name);
            };
            //Query Syntax
            //Starts with from
            //Query ends with select or group 
            string[] cities = { "Boston", "Los Angeles", "Seattle", "London" };

            IEnumerable<string> filteredCities =
                from city in cities
                where city.StartsWith("L") && city.Length < 15
                orderby city
                select city;
       
        }

        
    }
}
