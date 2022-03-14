using System;
using FizzBuzzKata;
using Xunit;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        [Fact]
        public void Get1()
        {
            var result = FizzBuzz.Generate(1);
            Assert.Equal("1", result);
        }
    }
}
