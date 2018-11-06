using System.Collections.Generic;
using System.Linq;

namespace Kata.model.Katas
{
    public class FizzBuzz
    {
        public string Label { get; set; }
        public int Value { get; set; }

        public static IEnumerable<string> ConvertFizzBuzz(int[] numbers)
            => numbers
                .Select(number =>
                            AddFizz(number))
               .Select(number =>
                            AddBuzz(number))
            .Select(number =>
                            AddFizzBuzz(number))
            .Select(fizzbuz => fizzbuz.Label);

        private static FizzBuzz AddFizzBuzz(FizzBuzz number)
        {
            return IsFizzBuzz(number.Value) ?
                                        new FizzBuzz { Label = "FizzBuzz", Value = number.Value } :
                                        new FizzBuzz { Label = number.Label, Value = number.Value };
        }

        private static FizzBuzz AddBuzz(FizzBuzz number)
        {
            return IsBuzz(number.Value) ?
                                        new FizzBuzz { Label = "Buzz", Value = number.Value } :
                                            new FizzBuzz { Label = number.Label, Value = number.Value };
        }

        private static FizzBuzz AddFizz(int number)
        {
            return IsFizz(number) ?
                                        new FizzBuzz { Label = "Fizz", Value = number } :
                                        new FizzBuzz { Label = number.ToString(), Value = number };
        }

        private static bool IsFizzBuzz(int number) => IsFizz(number) && IsBuzz(number);
        private static bool IsBuzz(int number) => number % 5 == 0;
        private static bool IsFizz(int number) => number % 3 == 0;
    }
}
