
using Fundamentals;
using System;
using Xunit;

namespace UnitTests
{
    
    public class UnitTest1
    {   //Xunit will search for Fact attribute to be attached
        [Fact]//Attribute, XUnit, piece of data attached
        public void Test1()
        {
            //Arrange objects and values

            var book = new InMemoryBook("Test");
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            book.AddGrade(89.1);

            //Act, or do something for result
            var result = book.GetStatistics();

            
            //Assert
            Assert.Equal(85.6, result.Average,1);
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);
            Assert.Equal('B', result.Letter);
        }
    }
}
