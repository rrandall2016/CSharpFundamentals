using System;

namespace TypeCasting
{
    class Program
    {
        public class Base
        {
            public Base()
            {

            }
        }
        public class Derived : Base
        {
            public Derived()
            {

            }
        }
        static void Main(string[] args)
        {
            //Type Casting---

            //int to double using automatic casting(implicit)
            int myInt = 9;
            double myDouble = myInt;

            //Convert string to number
            string stringToNumber = "777";
            int number = int.Parse(stringToNumber);

            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();

            int userName2Int = int.Parse(userName);

            Console.WriteLine(123 + userName2Int);

            //Convert to int from double
            double val = 21.34;
            int res = Convert.ToInt32(val);
            int res2 = (int)val;
            Console.WriteLine("Converted double {0} to integer {1} ", val, res);
            Console.WriteLine(res2);



            //For reference types
            //you can from child to parent, but not parent to child
            Derived d = new Derived();

            // Always OK.
            Base b = d;

            // Explicit conversions
            // is required to cast back
            // to derived type. Note: This will compile but will
            // throw an exception at run time if the right-side
            // object is not in fact a child of base.
            Derived d2 = (Derived)b;


            //Need to provide manual casting when losing information (truncated)
            double x = 1234.7;
            int a;
            //Manually casting here 
            a = (int)x;

            //Look up TryParse

        }
    }
}
