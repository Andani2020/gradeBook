using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAvarageGrade()
        {

            //Arrange
            var book = new Book("");
            book.AddGrade(89.4);
            book.AddGrade(49.4);
            book.AddGrade(59.6);

            //Act

            var result = book.GetStatistics();

            //Assert
            Assert.Equal(66.1, result.Average,1);
            Assert.Equal(89.4, result.High,1);
            Assert.Equal(49.4, result.Low,1);
            Assert.Equal('D', result.letter);
        }
    }
}
