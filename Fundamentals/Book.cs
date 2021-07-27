using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fundamentals.InMemoryBook;

namespace Fundamentals
{
    //IBook is more common than abstact classes, IBook is naming convention 

    //Interface contains definitions for a group of related functionalities
    //that a non-abstract class or a struct must implement.

    //Must implement to child class
    public interface IBook
    {
        void AddGrade(double grade);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }
    //Creates Book Name as Parent Class
    public class BookName
    {
        public BookName(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
    //Inherits from parent class BookName, and interface IBook
    public abstract class Book : BookName, IBook
    {
        //Because BookName requires name in the constructor so we use base 
        protected Book(string name) : base(name)
        {
        }

        public abstract event GradeAddedDelegate GradeAdded;
        public abstract void AddGrade(double grade); //All derived classes must have this, but they need to implement it 
        public abstract Statistics GetStatistics();

    }
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {

            //When providing this method with keyword using, it would free resoures up for us and provide a File.Close()

            using (var writer = File.AppendText($"D:\\C#-Basics\\FundamentalVideo\\Fundamentals\\Fundamentals\\Grades.txt"))
            {
                writer.WriteLine(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }

        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            using(var reader = File.OpenText($"D:\\C#-Basics\\FundamentalVideo\\Fundamentals\\Fundamentals\\Grades.txt"))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
    //without access modifier class book is given internal (class can only be used in same project)
    public class InMemoryBook : Book
    {
        //Fields Encapsulated
        private List<double> Grades;
      
        //Normally in different class
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        

        //Instant members or Instant methods of class Book
        public InMemoryBook(string name)
            : base(name)//Accessing NamedObject constructor, required because of NamedObject 
        {
            //Create new List for this book
            Grades = new List<double>();
            
        }
        //Use keyword override, to fill abstract class requirements
        //abstract means must implement but can only be used once
        public override void AddGrade(double grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                //This is the list add, not the one below 
                Grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}"); //nameof string version
            }
        }
        public override event GradeAddedDelegate GradeAdded;//Event makes it so you cant do book.GradeAdded = null;
        static public void Education()
        {
            //Static would mean it is associated with the class itself,
            //you could have one Grades list if used static
            //Static is not associated with an object
            //With static dont need to instantiate 
        }
        public override Statistics GetStatistics()
        {
            //Instantiate new object
            var result = new Statistics();

            //Do while runs at least once always -side note 
            var index = 0;
            while (index < Grades.Count)
            {
                result.Add(Grades[index]);
                index++;
            }

            return result;
        }
 
    }
}
