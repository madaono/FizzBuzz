using System;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void should_return_number_given_order_number()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var result = fizzBuzz.CountOff(2);
            Assert.Equal("2", result);
        }
        
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(12)]
        [InlineData(30)]
        public void should_return_fizz_given_number_is_times_3(int order)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var result = fizzBuzz.CountOff(order);
            Assert.Equal("Fizz", result);
        }
        
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(50)]
        public void should_return_buzz_given_number_is_times_5(int order)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var result = fizzBuzz.CountOff(order);
            Assert.Equal("Buzz", result);
        }
        
        [Theory]
        [InlineData(7)]
        [InlineData(14)]
        public void should_return_buzz_given_number_is_times_7(int order)
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var result = fizzBuzz.CountOff(order);
            Assert.Equal("Whizz", result);
        }
    }
}
