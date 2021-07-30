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
        
        //IEnumberable = 

        //IEnumberable<T> = Exposes the enumerator,
        //which supports a simple iteration over a collection of a specified type.
        //
        //
        //Lambda expression = short, concise, for defining a method I can invoke

        //Method vs Query syntax 

        //3 parts of LINQ execute = Data source, Query or Method creation, exection 

        //Other Examples
        //https://linqsamples.com/linq-to-objects/ordering/OrderBy-numbers



        static void Main(string[] args)
        {
            //Find numbers divisible by 2 and greater than 0      
            int[] numbers = { 0, 1, -2, 2,-3, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Example 1 print numbers in array divisable by 2");
            var methodQuery = numbers.Where(x => x % 2 == 0 && x >= 0);

            foreach (var number in methodQuery)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            
            //Find numbers greater than 0 and less than 7
            Console.WriteLine("Example 2 print numbers greater than 0 and less tha 7");
            var methodQuery2 = numbers.Where(x => x > 0).Where(x => x < 7);
            foreach (var number in methodQuery2)
            {
                Console.WriteLine(number);
            }


            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
            Console.Write("---------------------------------------------------------------------\n");
            Console.Write("The numbers in the array  are : \n");
            Console.Write(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");

            var n = arr1.GroupBy(x => x);
            Console.WriteLine("\nThe number and the Frequency are : \n");
            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }
            Console.WriteLine("\n");

            //GroupBy Practice
            var Cars = new List<Car>()
            {
                new Car() {VinNumber = 123456, CarBrand = "Tesla" },
                new Car() {VinNumber = 678911, CarBrand = "Ford" },
                new Car() {VinNumber = 549875, CarBrand = "BMW" },
                new Car() {VinNumber = 393488, CarBrand = "Tesla" },
                new Car() {VinNumber = 598392, CarBrand = "Ford" },
                new Car() {VinNumber = 934893, CarBrand = "BMW" }
            };
            //Group by creating a key, and assigns the elements based on the lambda expression 
            var newList = Cars.GroupBy(car => car.CarBrand);
            Console.WriteLine("\nThe CarBrand & VinNumber in each car of each CarsByBrand Group is : \n");
            foreach (var carsByBrand in newList)
            {
                foreach(var carInGroup in carsByBrand)
                {
                    Console.WriteLine(carInGroup.CarBrand + "vin = " + carInGroup.VinNumber);
                }
                
            }

        //LINQ Part 3
        //Array of Employee
        Employee[] developers = new Employee[]
        {
                new Employee {Id = 1, Name = "Scott"},
                new Employee {Id = 2, Name = "Chris"},
                new Employee {Id = 3, Name = "Dave"},
                new Employee {Id = 4, Name = "James"},
                new Employee {Id = 4, Name = "Ethan"}
        };

        //List of Employee
        List<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 4, Name = "Alex"},
                new Employee {Id = 5, Name = "John"},
                new Employee {Id = 6, Name = "Dave"}
            };

            //For every employee, keep employee that startswith S and print
            Console.WriteLine("\nThe names in the Employee array called developers that start with 'S' are : \n");
            foreach (var employee in developers.Where(
                 e => e.Name.StartsWith("S")
            ))
            {
                Console.WriteLine(employee.Name);
            }
            Console.WriteLine("\nFind employee in developers with certain Id and change name to Changed : \n");
            foreach (var employee in developers.Where(x => x.Id.Equals(2)))
            {
               if(employee.Name == "Chris")
               {
                    employee.Name = "Changed";
                    Console.WriteLine(employee.Name + " Worked");
               }
            }
            Console.WriteLine();
            //Method vs Query
            //Method
            var query = developers.Where(e => e.Name.Length == 5)
                .OrderBy(e => e.Name);
            Console.WriteLine("Find Name in Employees array that is 5 char long, and sort by name: ");
            foreach (var employeeX in query)
            {

                Console.WriteLine(employeeX.Name);
            }

            //Query
            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer;


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
