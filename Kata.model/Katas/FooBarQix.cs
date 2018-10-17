using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Kata.model.Katas.FooBarQixSpec;

namespace Kata.model.Katas
{
    public class FooBarQix
    {

        public string Word { get; private set; }
        public int Divisible { get; private set; }

        private static List<FooBarQix> FooBarQixTable = new List<FooBarQix>
        {
            new FooBarQix{Divisible = 3, Word="Foo"},
            new FooBarQix{Divisible = 5, Word="Bar"},
            new FooBarQix{Divisible = 7, Word="Qix"},
            new FooBarQix{Divisible = 0, Word="*"}
        };
        public static string Print(int value)
        {

            var modResult =
                    FooBarQixTable
                        .Where(ModIsZero(value))
                        .Aggregate(new StringBuilder(), (word, nextLetter) => word.AppendFormat(nextLetter.Word)).ToString();

            var numberContainsResult = value
                    .ToString()
                    .SelectMany(WhereFooBarQixTableDivisableContainsValue(FooBarQixTable))
                    .Aggregate(new StringBuilder(),
                    (word, nextLetter) => word.AppendFormat(nextLetter.Word)).ToString();

            var wordResult = string.Join("", modResult, numberContainsResult);

            return wordResult.Length < 3 ? value.ToString().Replace('0', '*') : wordResult;
        }

        private static IOrderedEnumerable<FooBarQix> GetWordFromDivisibleNumberThatContains(char letter)
            => FooBarQixTable.Where(fooBarQixItem =>
                fooBarQixItem.Divisible.ToString().Contains(letter)).OrderBy(item => item);
    }

    public static class FooBarQixSpec
    {
        public static Func<FooBarQix, bool> ModIsZero(int value)
                => foobarqix => foobarqix.Divisible != 0 && value % foobarqix.Divisible == 0;
        public static Func<char, IEnumerable<FooBarQix>> WhereFooBarQixTableDivisableContainsValue(IEnumerable<FooBarQix> fooBarQixTable)
                        => letter => fooBarQixTable.Where(fooBarQixItem =>
                fooBarQixItem.Divisible.ToString().Contains(letter)).OrderBy(item => item);
    }
}
