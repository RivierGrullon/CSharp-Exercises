using System;
using Xunit;


namespace Gradebook.Test
{
    public delegate string WritwLogDelagate(string logMessage);
    public class TypeTest
    {

        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {

            WritwLogDelagate log = ReturnMessage;
            log += IncrementCount;
            var result = log("Hello");
            Assert.Equal("Hello", result);
            Assert.Equal(2, count);

        }

        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        string IncrementCount(string message)
        {
            count++;
            return message;
        }

        [Fact]
        void ChangeTypeParameter()
        {
            var x = 3;
            setInt(ref x);
            Assert.Equal(42, x);
        }

        private void setInt(ref int x)
        {
            x = 42;
        }

        [Fact]
        public void ChangeBookName()
        {

            var book1 = GetBook("Book-1");
            var book2 = book1;
            Assert.Equal("Book-1", book1.Name);
            setName(book1, "klk");
            Assert.Same(book1, book2);
            Assert.Equal("klk", book1.Name);
        }

        private void setName(InMemoryBook book, string newName)
        {
            book.Name = newName;
        }

        [Fact]
        public void ChangeBookName2()
        {

            var book1 = GetBook("elpepe");
            GetAndsetName(ref book1, "klk");
            Assert.Equal("klk", book1.Name);
        }

        private void GetAndsetName(ref InMemoryBook book, string newName)
        {
            book = new InMemoryBook(newName);


        }

        [Fact]
        public void Test1()
        {

            var book1 = GetBook("Book-1");
            var book2 = GetBook("Scott's Grade Book");
            Console.WriteLine($"The name of the book1 is: {book1.Name}");
            Console.WriteLine($"The name of the book2 is: {book2.Name}");
            Assert.Equal("Scott's Grade Book", book2.Name);
            Assert.Equal("Book-1", book1.Name);
        }

        [Fact]
        public void CanValuePOintToTheSameValue()
        {

            var book1 = GetBook("Book-1");
            var book2 = book1;
            Console.WriteLine($"The name of the book1 is: {book1.Name}");
            Console.WriteLine($"The name of the book2 is: {book2.Name}");
            Assert.Same(book1, book2);
            Assert.Equal("Book-1", book1.Name);
        }


        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
