using ConnectingToSQLWithEFCore;
using System;
using System.Linq;

namespace ConnectingSQLWithEFCore
{
    class Program
    {
        //EF Core
        static void Main(string[] args)
        {
            //Insert data
            using (var context = new Context())
            {
                var std = new Student()
                {

                    Name = "Randy"

                };
                context.Students.Add(std);

                // or
                // context.Add<Student>(std);

                context.SaveChanges();
            }

            //Update record
            using (var context = new Context())
            {
                var std = context.Students.First<Student>();//LINQ
                std.Name = "Steve";
                context.SaveChanges();
            }
            //Delete record
            using (var context = new Context())
            {
                var std = context.Students.First<Student>();
                context.Students.Remove(std);

                // or
                // context.Remove<Student>(std);

                context.SaveChanges();
            }

        }
    }
}
