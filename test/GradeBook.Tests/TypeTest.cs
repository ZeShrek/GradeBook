using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
            var book1 = getBook("Book One");
            var book2 = getBook("Book Two");

            //act


            //assert
            Assert.Equal("Book One", book1.Name);
            Assert.Equal("Book Two", book2.Name);
            Assert.NotSame(book1, book2);

        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            //arrange
            var book1 = getBook("Book One");
            var book2 = book1;

            //act


            //assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }

        Book getBook(string name)
        {
            return new Book(name);
        }
    }
}
