using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedPractice
{
    public class StudentDatabase
    {
        public IList<Student> Students;

        public StudentDatabase()
        {
            Students = new List<Student>();

            int inc = 1;

            for (int i = 0; i < 10; i++)
            {
                Students.Add(new Student(inc,"Randy",i + "23 Testing st NW, Dallas Texas", DateTime.Now, "Science"));
                inc++;
                Students.Add(new Student(inc,"Kim",i + "23 Testing st NW, Salem Oregon", DateTime.Now, "English"));
                inc++;
                Students.Add(new Student(inc,"Luna",i  + "23 Testing st NW, Seattle Washington", DateTime.Now, "History"));
                inc++;
                Students.Add(new Student(inc,"Koga",i  + "23 Testing st NW, Portland Oregon", DateTime.Now, "Health"));
                inc++;
                Students.Add(new Student(inc,"Indy",i + "23 Testing st NW, Duluth Georgia", DateTime.Now, "IT"));
                inc++;
            }
        }

    }
}
