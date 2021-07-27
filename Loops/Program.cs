using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop
            //Continues until termination expression
            double whileIndex = 1;
            while(whileIndex < 4)
            {
                Console.WriteLine(whileIndex);
                whileIndex++;
            }

            //Foreach loop which is linear 
            List<string> Names = new();
            Names.Add("Randy");
            Names.Add("Kim");
            Names.Add("Koga");
            Names.Add("Indy");
            Names.Add("Luna");
            foreach(var name in Names)
            {
                Console.WriteLine(name);
            }

            //Do while, always runs at least once
            int count = 0;
            do
            {

                Console.WriteLine($"Do While {count}");
                count++;
            }
            while (count < 4);

            //For loop break
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"For loop before break: {i}");
                if(i == 2)
                {
                    break;
                }
            }
            //Nested for-loops Go style
            Console.Write("  ");
            //Create first set of columns 0-8
            for(int column = 0; column < 9; column++)
            {
                Console.Write($"{column} ");
            }
            Console.WriteLine();
            //Start side row and then all the ' -; chars. 1 - - - - - - - - 
            for (int row = 0; row < 9; row++)
            {
                Console.Write(row);
                for (int col = 0; col < 9; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine();
               
            }
            //Multidimensional Arrays
            int[,] array2D = new int[4, 2] { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 }, 
                { 7, 8 } };

            int total = 0;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for(int j = 0; j < array2D.GetLength(1); j++)
                {
                    total += array2D[i, j];
                }
            }
            Console.WriteLine(total);


        }
    }
}
