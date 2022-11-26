using FluentAssertions;
using Lib.Examples.IEqualityComparer.NotGeneric;

namespace Tests.IEqualityComparer.NotGeneric;

public class PersonTests
{
    [Fact]
    public void ShouldEqualsReturnTrue()
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

        var comparer = new PersonEqualityComparer();

        // act
        var equals = comparer.Equals(person1, person2);

        // assert
        equals.Should().BeTrue();
    }

    [Fact]
    public void ShouldEqualsReturnFalse()
    {
        // arrange
        var person1 = new Person
        {
            FirstName = "John",
            LastName = "Snow"
        };

        var person2 = new Person
        {
            FirstName = "Ned",
            LastName = "Stark"
        };

        var comparer = new PersonEqualityComparer();

        // act
        var equals = comparer.Equals(person1, person2);

        // assert
        equals.Should().BeFalse();
    }
}