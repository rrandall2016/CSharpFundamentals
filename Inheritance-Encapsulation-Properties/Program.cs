using System;

namespace Inheritance_Encapsulation_Properties
{
    //Inheritance-

    //All data properties are inherited and used without needing to write in each derived class
    //All methods from base class or derived class accessiable

    //Protected meaning all derived classes have access

    //Properties-
    //Use properties for that class to get or set the variable without other classes doing that(adds protection)
    //You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it).
    //However, sometimes we need to access them - and it can be done with properties.

    //Encapsulation-
    //*declare fields/variables as private
    //*provide public get and set methods, through properties, to access and update the value of a private field

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
    class BaseClass : Stats
    {
        public BaseClass()
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
    class ChildClassOne : BaseClass
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
            var Charmander = new BaseClass();
            Charmander.WeaknessPrint();
            Charmander.PokemonTypePrint();

            var Charmeleon = new ChildClassOne();
            Charmeleon.RagingFlames();

            var Charizard = new ChildClassTwo();
            Charizard.MaxWildfire();
            Console.WriteLine(Charizard.Attack);


        }
    }
}
