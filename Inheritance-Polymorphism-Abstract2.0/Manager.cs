using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism_Abstract2._0
{
    class Manager: Employee
    {
        //Invoke base constructor with base keyword
        public Manager(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }

        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been an email!");
        }

        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 5)
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 500!");
            else
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 250!");
        }
        //Must implement because abstract method in base class 
        public override double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * 2 * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }
    }
}
