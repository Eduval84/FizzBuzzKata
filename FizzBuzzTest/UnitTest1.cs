using System;
using Xunit;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        [Fact]
        public void Get1()
        {
            Assert.Equal("1", FizzBuzz.Generate(1));
        }
    }
}
