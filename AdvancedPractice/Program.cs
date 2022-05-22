using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fake DB
            var startDatabaseSeeding = new StudentDatabase();

            //LINQ extension methods
            var studentsInScience = startDatabaseSeeding.Students
                .Where(student => student.EducationDepartment == "Science")
                .OrderBy(student => student.Address)
                .ToList();

            int countThem = studentsInScience.Count();

            var studentsInIT = startDatabaseSeeding.Students
                .Where(student => student.EducationDepartment == "IT")
                .OrderBy(student => student.Address)
                .ToList();

            int countThem2 = studentsInIT.Count();

            var joinThem = studentsInScience.Union(studentsInIT);


            Console.WriteLine(studentsInIT[0].ToString());

            studentsInIT[0].chargeAccount();


            Console.WriteLine(studentsInIT[0].ToString());

            //Tuple
            for (int i = 0; i < 3; i++)
            {
                (int One, string Two) test1 = (studentsInIT[i].Id, studentsInIT[i].Name);
                
                if (test1.One == 1 || test1.Two == "Indy")
                {
                    studentsInIT[i].chargeAccount();
                    Console.WriteLine(test1 + "\n" + studentsInIT[i].Account);
                }
            };


            Console.WriteLine("How many in list1?: " + countThem);
            Console.WriteLine("How many in list2?: " + countThem2);
            Console.WriteLine("How many in list3?: " + joinThem.Count());

            Student new2 = new Student(1, "test", "testing", new DateTime(2001, 1, 1), "test");

            Student testing2 = new Student
            {
                Id = 22,
                Name = "test",
                Address = "test",
                BirthDateTime = new DateTime(2001, 1, 1),
                EducationDepartment = "test",

            };




        }
    }
}
