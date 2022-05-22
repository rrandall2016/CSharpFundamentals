using System;

namespace Inheritance_Polymorphism_Abstract2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manager Kimberly = new Manager("Kim", "Beautiful", "pretty@gmail.com", new DateTime(1999,9,9), 25);
            //Employee Kimberly2 = new Employee("Kim", "Beautiful", "pretty@gmail.com", new DateTime(1999,9,9), 25);


            Employee Kimberly = new StoreManager("Kim", "Beautiful", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
            Employee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
            Employee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);


            Kimberly.DisplayEmployeeDetails();
            Kimberly.PerformWork();
            Kimberly.PerformWork();
            Kimberly.PerformWork();
            Console.WriteLine(Kimberly.NumberOfHoursWorked);
            Kimberly.ReceiveWage();
            Kimberly.GiveBonus();
            

            //Only for Managers
            mary.AttendManagementMeeting();
            mary.PerformWork();
            mary.PerformWork();
            Console.WriteLine(mary.NumberOfHoursWorked);
            mary.ReceiveWage();


            //Static int variable from Employee class 
            var test = Employee.AlwaysSame;


            //var testing = Kimberly.SecretCode; Cant access due to private class property in Employee


            //Interfaces

            foreach (var employee in employees)
            {
                employee.DisplayEmployeeDetails();
            }


        }
    }
}
