using System;
using System.IO;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        //Async------

        //using threading.tasks

        //The await keyword provides a non-blocking way to start a task, then continue execution when that task completes.

        //You start a task and hold on to the Task object that represents the work. You'll await each task before working with its result.

        //Methods have async modifier in its signature.
        //That signals to the compiler that this method contains an await statement; it contains asynchronous operations.
        static void Main(string[] args)
        {
            //Example 1
            CallMethod();
            Console.ReadLine();

        }
        //Example 1
        static async void CallMethod()
        {
            string filePath = "D:\\C#-Basics\\FundamentalVideo\\Fundamentals\\FileIO\\people.txt";
            //Save the task where it says await in the method
            Task<int> task = ReadFile(filePath);
           
            //Now continue running this until you say
            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            //Now use the result from the task
            int length = await task;
            Console.WriteLine(" Total length: " + length);
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is starting");
            using (StreamReader reader = new StreamReader(file))
            {
                // Reads all characters from the current position to the end of the stream asynchronously
                // and returns them as one string.
                string s = await reader.ReadToEndAsync();

                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }
}
