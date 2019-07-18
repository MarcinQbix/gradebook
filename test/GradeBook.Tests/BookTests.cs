using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
          var book= new Book("");
         book.AddGrade(26.2);
            book.AddGrade(23.1);
            book.AddGrade(90.2);
            book.AddGrade(89.1);
           
             //act
           var result=  book.GetStatistics();
           //asssert
            Assert.Equal(57.15,result.Avarage,1);
            Assert.Equal(90.2, result.High);
        }
    }
}
