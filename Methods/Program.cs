using System;
using System.Collections.Generic;
using Program;

namespace Methods
{
    /*
    <access modifier> <return type> Method_Name(Parameters)
    {
        method statements
    }
    */

    //Same class static method = Don't need type name or new instance
    //Different class static method = Need type name, not new instance
    //Non-static method = need new instance of type name

    //Second class
    //Can be public, private, abstract, or sealed access level

    //Getters and Setters
    //Old way - private instance variable and public class methods
    //New way - properties encapsulates a set and get accessor

    class AccountGettersSetters
    {
        //Old way
        //private string name;

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        //New way
        public string Name {get; set;}
    }
    
    public class methodTesting
    {
        //Class members 
        public int Value = 5;//field
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
        public string Name;

        public returnObject(int id, string name)
        {
            Id = id;
            this.Name = name;
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
            Console.WriteLine("testing");
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
            testPassByRef.Multiply2(3, 2);

            //Refer to class name because it's in a different class than main one
            methodTesting.Multiply(3, 2);


            //We pass by value unless it is a class
            //Due to being static, did not need to make new instance
            nothingHappensPassValue(number);


            //A Static member 'member' cannot be accessed with an instance reference; qualify it with a type name instead
            var withTypeName= methodTesting.Multiply(number, number2);

            //Without static - different class
            var NotAStaticMethod = testPassByRef.Multiply2(number, number2);

            //Dont need type name if the method is in the same class
            int staticNoTypeNameNeeded = multiplyInClass(number, number2);

            //Method overloading - same name, different parameters 
            double itKnowsWhichOne = PlusMethod(90.1, 90.2);
            Console.WriteLine(itKnowsWhichOne);

            //named parameters allows you to choose which arguments to use
            PlusMethod(1, z: 3);

            //Return int array from method
            var newArray = returnArrayOfInt();

            //Return new object
            var newObject = CreateNewObject();


            //Creating object 
            List<Student> listOfStudents = new();
            //Populate list
            listOfStudents.Add(new Student(4,"Test4", 'A'));
            listOfStudents.Add(new Student(5,"Test5", 'B'));
            listOfStudents.Add(new Student(6,"Test6", 'C'));

            //Create new list other way...
            List<Student> authors = new List<Student>
            {
                new Student { Id = 7, Course = "Test7", Grade = 'A' },
                new Student { Id = 8, Course = "Test8", Grade = 'A' },
                new Student { Id = 9, Course = "Test9", Grade = 'A' }
            };

            //Instantiate individual objects
            Student student1 = new Student(1, "Test1", 'A');

            Student TestingThis = new Student
            {
                Id = 2,
                Course = "Test2",
                Grade = 'B'
            };

            Student student3 = new Student
            {
                Id = 2
            };

            //Public static void different class
            //
            Student.studentMethod(student1.Grade);

            //public int
            TestingThis.testingInstance(2);

            var testingReSharper = new Student();

            //Motorcycle
            
            MotorcycleAbstract testingAbstract = new TestMotorcycle();
            testingAbstract.StartEngine();
            MotorcycleAbstract.TestingThis();

            TestMotorcycle newTest = new TestMotorcycle();

            newTest.GetTopSpeed();

            TestMotorcycle.TestingThis();




            //More methods

        }
        //Method overloading
        static int PlusMethod(int x, int z, int y = 2)
        {
            return x + y + z;
        }
        //optional default parameters
        static double PlusMethod(double x, double y = 3.0, double z = 3.0)
        {
            return x + y + z;
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



        //Method only returns statement as a value can be re-written below
        //static int Cube(int x)
        //{
        //    return x * x * x;
        //}

        //expression-bodied method, not lambda
        static int Cube(int x) => x * x * x;

    }
}
