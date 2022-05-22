using System;

namespace Exception_Handling
{
    
    public class DivNumbers
    {
        int result;

        public DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
        class Program
    {

        static void Main(string[] args)
        {
            
                //DivNumbers d = new DivNumbers();
                //d.division(25, 0);
                //Console.ReadKey();

            int[] responses = {1,2,4,5,6,5,4,3,1,20};
            var frequency = new int[6];

            for(var answer = 0; answer < responses.Length; ++answer)
            {
                try
                {
                    //You will get the index exception when i is 4,
                    //because at that point, responses[4] is 6, and frequency[6] is out of bounds,
                    //as the frequency array only goes from 0-5
                    ++frequency[responses[answer]];
                }
                //declares an exception parameter’s type (IndexOutOfRangeException) and name (ex)
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($" responses[{answer}] = { responses[answer]}\n");
                }
            }

            //Console.WriteLine($"{"Rating"},{"Frequency",10}");
        }
    }
}
