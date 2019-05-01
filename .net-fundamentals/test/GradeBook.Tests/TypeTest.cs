using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
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

        void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
           var book1 = GetBook("Book 1");
           var newName = "New name";
            GetBookSetName(book1, newName);
            
            Assert.Equal("Book 1", book1.Name);
        }

        void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
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

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
