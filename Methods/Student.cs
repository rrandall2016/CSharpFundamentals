using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Student
    {
        public int Id { get; set; }
        public string Course { get; set; }
        public char Grade { get; set; }

        public Student() {}
        public Student(int id, string course, char grade)
        {
            Id = id;
            Course = course;
            Grade = grade;
        }

        public static void studentMethod(char grade)
        {
            if (grade.Equals('A'))
            {
                Console.WriteLine(grade.ToString());
            }
        }
        public int testingInstance(int id)
        {
            int result = testingInstance2(3);
            return id * result;

        }
        //Only used inside same class
        private int testingInstance2(int id)
        {
            return id * 2;
        }

    }
}
