using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzUtil
    {
        public static IEnumerable<string> GetFizzBuzzCollection(int count)
        {
            return count <= 0
                ? throw new ArgumentOutOfRangeException($"The number {count} is out of range.")
                : Enumerable.Range(1, count)
                            .Select(num =>
                                  $"{num}".Contains("3") && $"{num}".Contains("5") || num % 15 == 0 ? "FizzBuzz"
                                : $"{num}".Contains("3") || num % 3 == 0 ? "Fizz"
                                : $"{num}".Contains("5") || num % 5 == 0 ? "Buzz"
                                : $"{num}"
                            );
        }
    }
}
