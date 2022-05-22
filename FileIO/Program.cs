using Fundamentals;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //File input

            //Read from a text file 

            //When providing this method with keyword using, it would free resoures up for us and provide a File.Close()
            //This is true for ReadAllLines as well 

            //Version 1
            string[] lines = File.ReadAllLines(@"D:\C#-Basics\FundamentalVideo\Fundamentals\FileIO\people.txt");

            //Create a list for the updated string with all the removing/substring and etc
            List<string> NewPersonList = new List<string>();

            // Display the file contents by using a foreach loop.
            for(int i =0; i < 20; i++)
            {
                //Start with getting rid of front
                int findComma = lines[i].IndexOf(',');
                string CutVersion = lines[i].Substring(findComma + 1);

                //Get rid of everything in back of line
                int findComma2 = CutVersion.LastIndexOf(',');
                CutVersion = CutVersion.Remove(findComma2);
                CutVersion = CutVersion.Replace(',', ' ');
                NewPersonList.Add(CutVersion);

                Console.WriteLine(CutVersion);
            }

            //Version 2
            //Parsing from string to int and using objects 
            //Also adds grade to statistics list
            var result = new Statistics();
            using (var reader = File.OpenText(@"D:\C#-Basics\FundamentalVideo\\Fundamentals\Fundamentals\Grades.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);//convert string to double
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine(result.Count);

            //Write to a file
            //Creates a streamwriter that appends text to file 
            
            using (var writer = File.AppendText(@"D:\C#-Basics\FundamentalVideo\Fundamentals\FileIO\WritePeople.txt"))
            {
                for (int i = 0; i < 20; i++)
                {
                    //Use streamwriter variable to write line with string to write 
                    writer.WriteLine(NewPersonList[i]);

                }
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

            //MemoryStream - over file to store data, speed is better for MemoryStream. Series of bytes stored in memory. Only needs temp data

            
        }
    }
}
