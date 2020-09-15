using System;
using System.Linq;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzUtilTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void OutOfRangeTest(int input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FizzBuzzUtil.GetFizzBuzzCollection(input));
        }

        [Theory]
        [InlineData(10, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" })]
        [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "Fizz", "14", "FizzBuzz" })]
        [InlineData(50, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "Fizz", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "Fizz", "Fizz", "Buzz", "26", "Fizz", "28", "29", "FizzBuzz", "Fizz", "Fizz", "Fizz", "Fizz", "FizzBuzz", "Fizz", "Fizz", "Fizz", "Fizz", "Buzz", "41", "Fizz", "Fizz", "44", "FizzBuzz", "46", "47", "Fizz", "49", "Buzz" })]
        [InlineData(100, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "Fizz", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "Fizz", "Fizz", "Buzz", "26", "Fizz", "28", "29", "FizzBuzz", "Fizz", "Fizz", "Fizz", "Fizz", "FizzBuzz", "Fizz", "Fizz", "Fizz", "Fizz", "Buzz", "41", "Fizz", "Fizz", "44", "FizzBuzz", "46", "47", "Fizz", "49", "Buzz", "Fizz", "Buzz", "FizzBuzz", "Fizz", "Buzz", "Buzz", "Fizz", "Buzz", "Buzz", "FizzBuzz", "61", "62", "Fizz", "64", "Buzz", "Fizz", "67", "68", "Fizz", "Buzz", "71", "Fizz", "Fizz", "74", "FizzBuzz", "76", "77", "Fizz", "79", "Buzz", "Fizz", "82", "Fizz", "Fizz", "Buzz", "86", "Fizz", "88", "89", "FizzBuzz", "91", "92", "Fizz", "94", "Buzz", "Fizz", "97", "98", "Fizz", "Buzz"})]
        public void FizzBuzzTest(int input, string[] expected)
        {
            var actual = FizzBuzzUtil.GetFizzBuzzCollection(input).ToArray();
            Assert.Equal(expected, actual);
        }
    }
}
