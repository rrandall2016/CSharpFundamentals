
using Fundamentals;
using System;
using Xunit;

namespace Fundamentals
{

    //Delegate 
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTests
    {   //If using class for object = reference type
        [Fact]
        public void WriteLogDelegateMethod()
        {
            WriteLogDelegate log;
            log = ReturnMessage;
            var result = log("Hello!");
            Assert.Equal("Hello!", result);
        }
        string ReturnMessage(string message)
        {
            return message;
        }
        [Fact]
        public void Test1()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");


            Assert.Equal("Book 1", book1.Name);


        }

        private void GetBookSetName(Book book, string name)
        {
            book = new InMemoryBook(name);
        }
        /// <summary>
        /// This is passing by reference 
        /// </summary>
        [Fact]
        public void ChangeNameOfBook()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        Book GetBook(string name)
        {
            return new InMemoryBook(name);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            book1.Name = "Changed";
            Assert.Equal("Changed", book1.Name);
            Assert.Equal("Book 1", book2.Name);




            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }


    }
}
