using FluentAssertions;
using Kata.model.Katas;
using Xunit;

namespace Kata.Tests
{
    public class Kata_KarateChop
    {
        [Fact]
        public void ShouldPrintFooFoo()
        {
            FooBarQix.Print(3).Should().Be("FooFoo");
        }

        [Fact]
        public void ShouldPrintNumberWhenNotDivisibleByThree()
        {
            FooBarQix.Print(1).Should().Be("1");
        }

        [Fact]
        public void ShouldPrintBar()
        {
            FooBarQix.Print(10).Should().Be("Bar*");
        }

        [Fact]
        public void ShouldPrintQix()
        {
            FooBarQix.Print(7).Should().Be("QixQix");
        }

        [Fact]
        public void ShouldPrintFooBar()
        {
            FooBarQix.Print(51).Should().Be("FooBar");
        }
        [Fact]
        public void ShouldPrintBarFoo()
        {
            FooBarQix.Print(53).Should().Be("BarFoo");
        }

        [Fact]
        public void ShouldPrintFooFooFoo()
        {
            FooBarQix.Print(33).Should().Be("FooFooFoo");
        }

        [Fact]
        public void ShouldPrintFooBarBar()
        {
            FooBarQix.Print(15).Should().Be("FooBarBar");
        }

        [Fact]
        public void ShouldPrintFooQix()
        {
            FooBarQix.Print(21).Should().Be("FooQix");
        }

        [Fact]
        public void ShouldPrintEigth()
        {
            FooBarQix.Print(8).Should().Be("8");
        }

        [Fact]
        public void ShouldPrintFoo()
        {
            FooBarQix.Print(9).Should().Be("Foo");
        }

        [Fact]
        public void ShouldPrintBarWithAsterisk()
        {
            FooBarQix.Print(101).Should().Be("1*1");
            FooBarQix.Print(303).Should().Be("FooFoo*Foo");
            FooBarQix.Print(105).Should().Be("FooBarQix*Bar");
            FooBarQix.Print(10101).Should().Be("FooQix**");
        }

    }
}
