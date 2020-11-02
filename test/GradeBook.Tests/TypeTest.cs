using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTest
    {
        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(2, x);
        }

        private void SetInt(ref int x)
        {
            x = 2;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByReference()
        {
            //arrange
            var book1 = getBook("Origin");
            setNameAndGetNameByReference(ref book1, "Inferno");

            //assert
            Assert.Equal("Inferno", book1.Name);
        }

        private void setNameAndGetNameByReference(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            //arrange
            var book1 = getBook("Origin");
            setNameAndGetName(book1, "Inferno");

            //assert
            Assert.Equal("Origin", book1.Name);
        }

        private void setNameAndGetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = getBook("Origin");
            setName(book1, "Inferno");

            //assert
            Assert.Equal("Inferno", book1.Name);
        }

        private void setName(Book book, string newName)
        {
            book.Name = newName;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Dan Brown";
            var upperName = MakeUpperCase(name);

            Assert.Equal("Dan Brown", name);
            Assert.Equal("DAN BROWN", upperName);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
            var book1 = getBook("Origin");
            var book2 = getBook("Inferno");

            //assert
            Assert.Equal("Origin", book1.Name);
            Assert.Equal("Inferno", book2.Name);
            Assert.NotSame(book1, book2);

        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            //arrange
            var book1 = getBook("Origin");
            var book2 = book1;

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
