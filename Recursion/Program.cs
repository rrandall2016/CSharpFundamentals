using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    //Base case means reached end of recursion calls
    class Test
    {
        public int Test2 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; ++i)
            {
                Console.WriteLine($"{i}! = {Factorial(i)}");
            }

            // new Test is an object-creation expression, or creating an instance 
            var test = new Test();

            int x;
        }
        static long Factorial(long number)
        {
            //base case
            if(number<= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        
        
    }
}
