using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        int count = 0;
        //   [Fact]
        // public void CSharpCanPassByRef()
        // {
        //    var book1 = GetBook("Book 1");
        //    var newName = "New name";
        //     GetBookSetName(out book1, newName);
            
        //     Assert.Equal(book1.Name, newName);
        // }

        // void GetBookSetName(out Book book, string name)
        // {
        //     // with out keyword we must initialize a variable before leaving the method
        //     book = new Book(name);
        // }
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            // LONG SYNTAX FOR DELEGATE INIT
            // log = new WriteLogDelegate(ReturnMessage);

            // SHORT SYNTAX FOR DELEGATE INIT
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");
            Assert.Equal(3, count);
        }

        string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }

        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Mario Andres";
            var upper = MakeUpperCase(name);

            Assert.Equal("Mario Andres", name);
            Assert.Equal("MARIO ANDRES", upper);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        void SetInt(ref int x)
        {
            x = 42;
        }

        int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
           var book1 = GetBook("Book 1");
           var newName = "New name";
            GetBookSetName(ref book1, newName);
            
            Assert.Equal(book1.Name, newName);
        }

        void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
           var book1 = GetBook("Book 1");
           var newName = "New name";
            GetBookSetName(book1, newName);
            
            Assert.Equal("Book 1", book1.Name);
        }

        void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
           var book1 = GetBook("Book 1");
           var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
           var book1 = GetBook("Book 1");
           var book2 = book1;
           Assert.Same(book1, book2);
           Assert.True(Object.ReferenceEquals(book1, book2));
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
