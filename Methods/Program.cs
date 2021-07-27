using System;

namespace Methods
{

    //Same class static method = Don't need type name or new instance
    //Different class static method = Need type name, not new instance
    //Non-static method = need new instance of type name

    //Second class
    //Can be public, private, abstract, or sealed access level
    
    public class methodTesting
    {
        //Class members 
        public int value = 5;//field
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Multiply2(int x, int y)
        {
            return x * y;
        }
    }
    public class returnObject
    {
        public int Id;
        public string name;

        public returnObject(int id, string name)
        {
            Id = id;
            this.name = name;
        }
    }
    //Main class
    class Program
    {
        //When not using static keyword, you must create an instance of the class
        public int Sum(int x, int y)
        {
            return x + y;
        }
        static void nothingHappensPassValue(int x)
        {
            x = 100;
        }
        static void PassByReference(methodTesting test)
        {
            test.value = 10;
        }
        static int multiplyInClass(int x, int y)
        {
            return x * y;
        }
        static int RunsAndStoresValue()
        {
            Console.WriteLine("testing11111");
            return 10;
        }
        static void Main(string[] args)
        {

            var ConsoleOutAndStoreValue = RunsAndStoresValue();

            int number = 10;
            int number2 = 11;

            //Create instance of this class to use Sum because Sum is not static
            var test = new Program();
            int Sum = test.Sum(number, number2);


            //Must make new instance 
            var testPassByRef = new methodTesting();
            //Passing by reference, when object passed to method
            PassByReference(testPassByRef);


            //We pass by value unless it is a class
            //Due to being static, did not need to make new instance
            nothingHappensPassValue(number);


            //A Static member 'member' cannot be accessed with an instance reference; qualify it with a type name instead
            var withTypeName= methodTesting.Multiply(number, number2);

            //Without static - different class
            var NotAStaticMethod = testPassByRef.Multiply2(number, number2);

            //Dont need type name if the method is in the same class compared to static member in different class
            int staticNoTypeNameNeeded = multiplyInClass(number, number2);

            //Method overloading - same name, different parameters 
            double itKnowsWhichOne = PlusMethod(90.1, 90.2);
            Console.WriteLine(itKnowsWhichOne);

            //Return int array from method
            var newArray = returnArrayOfInt();

            //Return new object
            var newObject = CreateNewObject();
        }
        //Method overloading
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        //Return int array 
        static int[] returnArrayOfInt()
        {
            int[] newArray = new int[5] { 1, 2, 3, 4, 5 };
            return newArray;
        }
        //Return object
        static returnObject CreateNewObject()
        {
            var newObject = new returnObject(1,"Randy");
            //Do some logic 
            return newObject;


        }

    }
}
