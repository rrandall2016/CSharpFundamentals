using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism_Abstract2._0
{
    public class Researcher : Employee
    {
        public Researcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }

        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;
            Console.WriteLine($"Researcher {FirstName} {LastName} is has invented a new pie taste!");
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
    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
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

