using FluentAssertions;
using Lib.Examples.IComparable.NonGeneric;

namespace Tests.IComparable.NotGeneric;

public class PersonTests
{
    [Fact]
    public void ShouldCompareReturnsZero()
    {
        // arrange
        var person1 = new Person
        {
            FirstName = "John",
            LastName = "Snow"
        };

        var person2 = new Person
        {
            FirstName = "John",
            LastName = "Snow"
        };

        // act
        var result = person1.CompareTo(person2);

        // assert
        result.Should().Be(0);
    }

    [Fact]
    public void ShouldCompareReturnsPositiveValue()
    {
        // arrange
        var person1 = new Person
        {
            FirstName = "John2",
            LastName = "Snow2"
        };

        var person2 = new Person
        {
            FirstName = "John1",
            LastName = "Snow1"
        };

        // act
        var result = person1.CompareTo(person2);

        // assert
        result.Should().Be(1);
    }

    [Fact]
    public void ShouldCompareReturnsNegativeValue()
    {
        // arrange
        var person1 = new Person
        {
            FirstName = "John1",
            LastName = "Snow1"
        };

        var person2 = new Person
        {
            FirstName = "John2",
            LastName = "Snow2"
        };

        // act
        var result = person1.CompareTo(person2);

        // assert
        result.Should().Be(-1);
    }
}