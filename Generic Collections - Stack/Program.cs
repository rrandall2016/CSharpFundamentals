using System;
using System.Collections.Generic;
using System.Data;

namespace Generic_Collections___Stack
{
    class Program
    {
        //Stack for valid parentheses
        Dictionary<char,char> map = new()
        {
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };
        Stack<char> stack2 = new();
        public bool IsValid(string s)
        {
            //Check each char in string, if it's key it is open parentheses and push to stack
            foreach (var c in s.ToCharArray())
            {
                if (map.ContainsKey(c))
                {
                    stack2.Push(c);
                }
                else
                {
                    //Is stack empty then false
                    if (stack2.Count == 0)
                    {
                        return false;
                    }
                    //Pop the stack and check if value matches to key if not, return false
                    char open = stack2.Pop();
                    if (map[open] != c)
                    {
                        return false;
                    }
                }
            }
            //If stack is empty, all parentheses matched
            return stack2.Count == 0;
        }
        static void Main(string[] args)
        {
            //Stack<T>
            //Stack FILO
            //Push = add to back of line, Peek = return but dont delete, Pop = return and delete

            //Big O = O(n) access/search O(1) push/pop (insertion, deletion)

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Top value with peek: {0}", stack.Peek());

            //You can save the value being popped but it wont be in stack
            int myStackItem = stack.Pop();
            Console.WriteLine("Top value with peek: {0}", stack.Peek());

            while (stack.Count > 0)
            {
                stack.Pop();
            }
            Console.WriteLine(stack.Count);

            int[] newStack = new int[] { 1, 4, 5, 7, 8 };

            Stack<int> myStack = new Stack<int>();


            for (int i = 0; i < newStack.Length; i++)
            {
                myStack.Push(newStack[i]);

            }
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop() + " ");
            }
            Console.WriteLine("-----------------");

            Program testing = new();
            Console.WriteLine(testing.IsValid("{(())}"));


        }
    }
}
