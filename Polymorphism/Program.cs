using System;
using System.Collections.Generic;

namespace Polymorphism
{
    //Polymorphism-
    //Derived classes have same method as the base class, but since we use virtual keyword the computer will figure out which one to use
    //Derived classes with virtual method must use OVERRIDE keyword

    //Abstract classes-
    //if you have an abstract class with a property in it and 3 classes inheriting from it,
    //you write the property once in the abstract and the three children get it
    //With interfaces you have to write the properties
    public abstract class PlayerStats
    {
        public int Health { get; set; }
        public void Sleeping()
        {
            Console.WriteLine("Sleeping");
        }
    }
    interface ISpecial
    {
        public string InterfaceForcesYouToImplement { get; set; }
        void SpecialDefense();

    }
    public class Player : PlayerStats
    {
        private List<BaseClass> PokemonList;
        public string Name { get; set; }

        public Player(string name)
        {
            PokemonList = new List<BaseClass>();
            this.Name = name;
            Health = 100;
        }
        public void AddPokemonToList(BaseClass pokemon)
        {
            PokemonList.Add(pokemon);
        }
        public void PrintPokemonList()
        {
            foreach(var pokemon in PokemonList)
            {
                Console.WriteLine(pokemon.PokemonName);
            }
        }
    }
    public class Stats
    {
        public string[] PokemonType { get; set; }
        public string PokemonName { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        protected string[] Weaknesses = new string[3] { "Water", "Ground", "Rock" };
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
    public class BaseClass : Stats , ISpecial
    {
        //ISpecial interface forces you to write the same thing twice
        public string InterfaceForcesYouToImplement { get; set; }
        public BaseClass()
        {
            PokemonName = "Charmander";
            PokemonType = new string[] { "Fire" };
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

        public virtual void SpecialAttack()
        {
            Console.WriteLine("Special Attack!!! 30 dmg");
        }
        public virtual void SpecialDefense()
        {
            Console.WriteLine("Special Defense!!! 30 def");
        }
    }
    public class ChildClassOne : BaseClass , ISpecial
    {
        public ChildClassOne()
        {
            PokemonName = "Charmeleon";
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
        public override void SpecialAttack()
        {
            Console.WriteLine("Special Attack!!! 50 dmg");
        }
        public override void SpecialDefense()
        {
            Console.WriteLine("Special Defense!!! 50 def");
        }
    }
    class ChildClassTwo : ChildClassOne, ISpecial
    {
        public ChildClassTwo()
        {
            PokemonName = "Charizard";
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
        public override void SpecialAttack()
        {
            Console.WriteLine("Special Attack!!! 70 dmg");
        }
        public override void SpecialDefense()
        {
            Console.WriteLine("Special Defense!!! 70 def");
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

            Charmander.SpecialAttack();
            Charmeleon.SpecialAttack();
            Charizard.SpecialAttack();

            var Ash = new Player("Ash");
            Ash.AddPokemonToList(Charmander);
            Ash.AddPokemonToList(Charmeleon);
            Ash.AddPokemonToList(Charizard);

            Ash.PrintPokemonList();



        }
    }
}
