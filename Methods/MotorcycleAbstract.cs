using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    abstract class MotorcycleAbstract
    {
        // Anyone can call this.
        public void StartEngine()
        {
            /* Method statements here */
            Console.WriteLine("Engine Start");
        }

        // Only derived classes can call this.
        protected void AddGas(int gallons)
        {
            /* Method statements here */
            Console.WriteLine(gallons);
        }

        // Derived classes can override the base class implementation.
        public virtual int Drive(int miles, int speed)
        {
            /* Method statements here */

            return miles + speed;
        }

        // Derived classes must implement this.
        public abstract double GetTopSpeed();
        public static void TestingThis(){Console.WriteLine("test");}
    }

    class TestMotorcycle : MotorcycleAbstract
    {

        public override double GetTopSpeed()
        {
            return 108.4;
        }


    }
}
