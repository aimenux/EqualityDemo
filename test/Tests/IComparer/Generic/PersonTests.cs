using FluentAssertions;
using Lib.Examples.IComparer.Generic;

namespace Tests.IComparer.Generic;

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

        var comparer = new PersonComparer();

        // act
        var result = comparer.Compare(person1, person2);

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

        var comparer = new PersonComparer();

        // act
        var result = comparer.Compare(person1, person2);

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

        var comparer = new PersonComparer();

        // act
        var result = comparer.Compare(person1, person2);

        // assert
        result.Should().Be(-1);
    }
}