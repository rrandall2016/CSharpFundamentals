using System;

namespace ConsoleApp1
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance
    class Program
    {
        class Tank
        {

            double t_radius;
            double t_height;

            // Constructor for Tank
            public Tank(double r, double h)
            {
                Radius = r;
                Height = h;
            }

            // Properties for Radius
            // and Height
            public double Radius
            {
                get
                {
                    return t_radius;
                }

                set
                {
                    t_radius = value < 0 ? -value : value;
                }
            }

            public double Height
            {
                get
                {
                    return t_height;
                }

                set
                {
                    t_height = value < 0 ? -value : value;
                }
            }

            // Display the dimension of tanks
            public void DisplayDimension()
            {
                Console.WriteLine("The radius of tank is :" + Radius
                         + " and the height of tank is :" + Height);
            }
        }

        // AreaOfTank is derived class 
        // which is inheriting the Tank class
        class AreaOfTank : Tank
        {

            string Color;

            // Call the Constructor of the 
            // base class, i.e Tank
            // Using base keyword
            public AreaOfTank(string c, double r,
                           double h) : base(r, h)
            {
                Color = c;
            }

            // Return area of tank
            public double Area()
            {
                return 2 * 3.14 * Radius * Height;
            }

            // Display the color of tank
            public void DisplayColor()
            {
                Console.WriteLine("The Color of tank is " + Color);
            }
        }

        // Driver Class
        class GFG
        {

            // Main Method
            static void Main()
            {
                // Create and initialize the 
                // object of AreaOfTank
                AreaOfTank t1 = new AreaOfTank("Brown", 4.0, 8.0);
                t1.DisplayColor();
                t1.DisplayDimension();
                Console.WriteLine("Area is " + t1.Area());
            }
        }
    }
}