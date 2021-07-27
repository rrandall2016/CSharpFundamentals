using System;

namespace Delegates
{
    //Delegates
    //A delegate is a type that safely encapsulates a method, similar to a function pointer in C and C++.
    class Program
    {
        public delegate void Del(string message);
        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
        static void Main(string[] args)
        {
            // Instantiate the delegate.
            Del handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");

            MethodWithCallback(1, 2, handler);
        }
    }
}
