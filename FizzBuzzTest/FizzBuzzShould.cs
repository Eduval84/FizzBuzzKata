using System;
using System.Diagnostics.CodeAnalysis;
using FizzBuzzKata;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzShould
    {
        [Fact]
        public void Get1AsString()
        {
            var result = FizzBuzz.Generate(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void Get2AsString()
        {
            var result = FizzBuzz.Generate(2);
            Assert.Equal("2",result);
        }

        [Fact]
        public void GetFizzFor3()
        {
            var result = FizzBuzz.Generate(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Get4AsString()
        {
            var result = FizzBuzz.Generate(4);
            Assert.Equal("4", result);
        }
        
        [Fact]
        public void GetBuzzFor5g()
        {
            var result = FizzBuzz.Generate(5);
            Assert.Equal("Buzz", result);
        }
    }
}
