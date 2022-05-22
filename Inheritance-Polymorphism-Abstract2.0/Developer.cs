using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism_Abstract2._0
{
    //Sealed stops classes from inheriting from this class
    public sealed class Developer : Employee
    {
        public Developer(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }

        public override double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }
    }
}
