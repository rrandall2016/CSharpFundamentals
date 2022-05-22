using System;
using System.Globalization;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hireDate = new DateTime(2021, 3, 28);
            DateTime hireDate2 = DateTime.Now;
            DateTime hireDate3 = DateTime.UtcNow;
            Console.WriteLine(hireDate);
            Console.WriteLine(hireDate2);
            Console.WriteLine(hireDate3);

            hireDate = hireDate.AddYears(1);
            Console.WriteLine(hireDate);

            TimeSpan workTime = new TimeSpan(8, 0, 0);

            hireDate2 = hireDate2.Add(workTime);
            Console.WriteLine(hireDate2);

            Console.WriteLine(hireDate2.ToLongDateString());
            Console.WriteLine(hireDate2.ToShortDateString());

        }
    }
}
