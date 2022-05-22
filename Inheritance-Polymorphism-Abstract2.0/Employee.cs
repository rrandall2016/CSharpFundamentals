using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphism_Abstract2._0
{
    public abstract class Employee
    {
        public static double taxRate = 0.15;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        //Shared among all 
        public int NumberOfHoursWorked { get; set; }

        public double Wage { get; set; }

        public double? HourlyRate { get; set; }

        public DateTime BirthDay { get; set; }

        //Only this class can access not even derived classes
        private int SecretCode { get; set; }

        public static int AlwaysSame = 10;

        public Employee(string first, string last, string em, DateTime bd, double? rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            HourlyRate = rate ?? 10;
        }

        public void PerformWork()
        {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }


        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }
        //No body for abstract
        public abstract double ReceiveWage();

        //Can override in derived class //Polymorphism 
        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\nTax rate: {taxRate}");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

    }
}
