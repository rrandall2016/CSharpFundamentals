using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedPractice
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BirthDateTime { get; set; }
        public string EducationDepartment { get; set; }
        public double Account { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string name, string address, DateTime birthDate, string educationDepartment)
        {
            Id = id;
            Name = name;
            Address = address;
            BirthDateTime = birthDate;
            EducationDepartment = educationDepartment;
            Account = 0;

        }
        //Override ToString()
        public override string ToString()
        {
            return Id + "\n" +
                   Name + "\n" +
                   Address + "\n" +
                   BirthDateTime + "\n" +
                   EducationDepartment + "\n" +
                   "$" + Account + "\n";
        }

        public void chargeAccount()
        {
            Account += 3000.00;
        }
    }
}
