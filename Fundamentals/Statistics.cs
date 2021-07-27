using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Statistics
    {
        
        public double High;
        public double Low;
        public double Sum;
        public int Count;
        //Property can have things
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90.0:
                        return 'A';
                    case var d when d >= 80.0:
                        return 'B';
                    case var d when d >= 70.0:
                        return 'C';
                    case var d when d >= 60.0:
                        return 'D';
                    default:
                        return 'F';

                }
            }
        }
        public double Average
        {
            get
            {
                return Math.Round(Sum / Count, 2);
            }
        }
        //Constructor
        public Statistics()
        {
            Count = 0;
            High = double.MinValue;//Smallest possible value
            Low = double.MaxValue;//Largest ^
            Sum = 0.0;

        }
        //Adds the sum with each input number
        //Low and high calculated 
        //Count increments 
        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
        }

    }
}
