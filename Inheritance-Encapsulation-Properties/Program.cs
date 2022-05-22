using System;

namespace Inheritance_Encapsulation_Properties
{
    //Inheritance-

    //All data properties are inherited and used without needing to write in each derived class
    //All methods from base class or derived class accessiable

    //Protected meaning all derived classes have access

    //Properties-
    //Use properties for that class to get or set the variable without other classes doing that(adds protection)
    //Private variables can only be accessed within the same class (an outside class has no access to it).
    //However, sometimes we need to access them - and it can be done with properties.

    //Encapsulation-
    //*declare fields/variables as private
    //*provide public get and set methods, through properties, to access and update the value of a private field

    //Part 1
    class Parent
    {
        public void ParentMethod()
        {
            Console.WriteLine("this is parent method");
        }
    }
    class child : Parent
    {
        public void childmethod()
        {
            Console.WriteLine("this is child method");
        }

    }
    //Part 2 
    public class Stats
    {
        public string[] PokemonType { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        protected string[] Weaknesses = new string[3]{"Water", "Ground", "Rock"};
        public string Category { get; set; }
        public void WeaknessPrint()
        {
            foreach (var weakness in Weaknesses)
            {
                Console.WriteLine(weakness);
            }
        }
        public void PokemonTypePrint()
        {
            foreach (var type in PokemonType)
            {
                Console.WriteLine(type);
            }
        }
    }
    class ChildClassZero : Stats
    {
        public ChildClassZero()
        {
            PokemonType = new string[]{"Fire"};
            Category = "Lizard";
            Hp = 30;
            Attack = 40;
            Defense = 30;
            Speed = 30;
        }
        public void Flare()
        {
            Console.WriteLine("Attacking with flare");
        }
    }
    class ChildClassOne : ChildClassZero
    {
        public ChildClassOne()
        {
            PokemonType = new string[] { "Fire" };
            Category = "Flame";
            Hp = 40;
            Attack = 40;
            Defense = 40;

        }

        public void RagingFlames()
        {
            Console.WriteLine("Attacking with raging flames");
        }
    }
    class ChildClassTwo : ChildClassOne
    {
        public ChildClassTwo()
        {
            PokemonType = new string[] { "Fire", "Flying" };
            Category = "Flame";
            Hp = 50;
            Attack = 50;
            Defense = 50;
        }
        public void MaxWildfire()
        {
            Console.WriteLine("Attacking with max wildfire");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Rule 1
            //If inherited, the execution of any child class starts by invoking its parent class's default constructor by default.
            child obj = new child();
            obj.childmethod();
            obj.ParentMethod();
            

            //Rule 2
            //In inheritance the child class can access its parent class's members but a parent class can never access its child class member.
            Parent p = new Parent();
            p.ParentMethod();//valid  
            //p.childmethod();//invalid 

            //Rule 3
            //In the same way an object of a class can also be assigned to its parent class variable and make it as a reference,
            //but in this scenario we are also using the parent reference.
            //We cannot access only a member that is purely defind in the child class even if the reference is consuming the same object memory.
            child obj2 = new child();
            Parent p2 = obj2;
            p2.ParentMethod();//access only the parent member.  
            //p2.childmethod();//invalid cannot access child member 

            //Rule 4: Each and every class we define in .Net languages has an implicit parent class (in other words, the class object) defined in the system namespace.
            //So the members of this class as in the following: Equals, GetHashCode, GetType,ToString

            // A Derived Class’s Constructor Must Call Its Base Class’s Constructor



            var Charmander = new ChildClassZero();
            Charmander.WeaknessPrint();
            Charmander.PokemonTypePrint();
            Console.WriteLine(Charmander.Hp);

            var Charmeleon = new ChildClassOne();
            Charmeleon.RagingFlames();
            Charmeleon.WeaknessPrint();

            var Charizard = new ChildClassTwo();
            Charizard.MaxWildfire();
            Console.WriteLine(Charizard.Attack);


        }
    }
}
