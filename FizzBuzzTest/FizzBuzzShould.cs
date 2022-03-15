using System;
using System.Diagnostics.CodeAnalysis;
using FizzBuzzKata;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(1,"1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void ReturnNumberAsString(int input, string expectedOutput)
        {
            var result = FizzBuzz.Generate(input);
            Assert.Equal(expectedOutput, result);
        }


        [Theory]
        [InlineData(3,"Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        public void GetFizzForNumsDivisiblesBy3(int input, string expectedOutput)
        {
            var result = FizzBuzz.Generate(input);
            Assert.Equal(expectedOutput, result);
        }


        [Theory]
        [InlineData(5,"Buzz")]
        [InlineData(10, "Buzz")]
        public void GetBuzzForNumsDivisibleBy5(int input, string expectedOutput)
        {
            var result = FizzBuzz.Generate(input);
            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData(15,"FizzBuzz")]
        [InlineData(30, "FizzBuzz")]

        public void GetFizzBuzzForNumbersDibisiblesBy3And5(int input, string expectedOutput)
        {
            var result = FizzBuzz.Generate(input);
            Assert.Equal(expectedOutput, result);
        }
    }
}
