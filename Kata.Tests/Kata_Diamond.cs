using FluentAssertions;
using Kata.model.Katas;
using Xunit;

namespace Kata.Tests
{
    public class Kata_Diamond
    {

        [Fact]
        public void ShouldPrintLetterSequence()
        {
            var result = Diamond.PrintUntil("F");
            result.Should().BeEquivalentTo(new string[] { "A", "B", "C", "D", "E", "F" });

        }


        [Fact]
        public void SouldPrintLetterSequenceIdented()
        {
            var result = Diamond.Print("C");
            result.Should()
                .Be("\n   A\n  B B\n C   C\n  B B\n   A");
        }

        [Fact]
        public void SouldPrintLetterBigSequenceIdented()
        {
            var result = Diamond.Print("J");
            result.Should()
                .Be("\n          A\n         B B\n        C   C\n       D     D\n      E       E\n     F         F\n    G           G\n   H             H\n  I               I\n J                 J\n  I               I\n   H             H\n    G           G\n     F         F\n      E       E\n       D     D\n        C   C\n         B B\n          A");
        }


    }
}
