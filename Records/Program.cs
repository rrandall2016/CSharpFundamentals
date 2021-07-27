using System;

namespace Records
{
    //Records are not immutable if you have the set keyword
    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
    public record Course2
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
    public class TestClass
    {
        public string Name { get; set; }
    }
    public record TestRecord
    {
        public string Name { get; set; }
    }
    //Short hand
    public record CourseRecord(string Name, string Author);

    //Long Hand
    //public record CourseRecord
    //{
    //    public string Name { get; }
    //    public string Author { get; }
    //    public CourseRecord(string name, string author) => (Name, Author) = (name, author);
    //}

    class Program
    {
        //Records
        //Immutability
        //Data and statistics are among the scenarios where you'll want to use records.
        //Is a reference type
        //


        static void Main(string[] args)
        {
            var pluralightCourse = new Course();
            pluralightCourse.Name = "Records";
            pluralightCourse.Author = "Randall";


            //Records instance is immutable(values can not be changed once object constructed)
            //
            var classroomCourse = new CourseRecord(
                "Working with C# Records",
                "Roland Guijt"
                );

            var classroomCourse2 = new Course2();
            classroomCourse2.Name = "Testing";
            classroomCourse2.Author = "Testing again";

            //The big difference is that records use value-equality, not reference-equality

            TestClass c1 = new() { Name = "Bob" };
            TestClass c2 = new() { Name = "Bob" };
            Console.WriteLine(c1 == c2); // false

            TestRecord r1 = new() { Name = "Bob" };
            TestRecord r2 = new() { Name = "Bob" };
            Console.WriteLine(r1 == r2); // true

        }
    }
}
