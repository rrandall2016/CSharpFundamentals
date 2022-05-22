using System;

namespace EnumAndStructsAreValueTypes
{
    class Program
    {
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        public readonly struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; init; }
            public double Y { get; init; }

            public override string ToString() => $"({X}, {Y})";
        }
        static void Main(string[] args)
        {
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");  // output: Integral value of Autumn is 2

            var b = (Season)1;
            Console.WriteLine(b);  // output: Summer

            var c = (Season)4;
            Console.WriteLine(c);  // output: 4

            //Structs
            var p1 = new Coords(0, 0);
            Console.WriteLine(p1);  // output: (0, 0)

            //





        }
    }
}
