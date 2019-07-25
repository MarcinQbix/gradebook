using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        public delegate string writeLogDelegate(string logMessage);

[Fact]
public void WriteLogDelegateCanPointtoMethod()
{
    writeLogDelegate log;
   log = ReturnMessage;
   var result = log("Hello!");
    Assert.Equal("Hello!", result);
}
string ReturnMessage(string message)
{
    return message;
}
        [Fact]
        public void CanSetNameFromReference(){

var book1= GetBook("Book 1");
SetName(book1, "new Name");
Assert.NotEqual("Book 1", book1.Name);
Assert.Equal("new Name", book1.Name);

        }

        private void SetName(InMemoryBook book, string name)
        {book.Name=name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
      var book1= GetBook("book 1");
    var book2= GetBook("book 2");
    Assert.Equal("book 1",book1.Name);
    Assert.Equal("book 2",book2.Name);
    Assert.NotEqual(book1,book2);
                       //act
               //asssert
         
        }
        [Fact]
             public void TwoVarsCanReferenceSameObject()
        {
            //arrange
      var book1= GetBook("book 1");
    var book2=book1;
Assert.Same(book1,book2);
Assert.True(Object.ReferenceEquals(book1,book2));
                       //act
               //asssert
         
        }

         InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
