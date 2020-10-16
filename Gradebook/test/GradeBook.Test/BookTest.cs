using System;
using Xunit;


namespace Gradebook.Test {
    public class BookTests {
        [Fact]
        public void BookCalculateAverageGrade() {

            //* arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //* act
            var results = book.GetStatistics();

            //* assert
            Assert.Equal(85.6, results.Average, 1);
            Assert.Equal('B', results.Letter);
            Console.WriteLine($"The highgrade is: {results.High}\nThe lowest Grade is: {results.Low}");
            Console.WriteLine($"The average in the grade is {results.Average:N1}");
        }
    }
}
