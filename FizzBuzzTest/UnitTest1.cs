using System;
using System.Diagnostics.CodeAnalysis;
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

        [Fact]
        public void Get2()
        {
            var result = FizzBuzz.Generate(2);
            Assert.Equal("2",result);
        }
    }
}
