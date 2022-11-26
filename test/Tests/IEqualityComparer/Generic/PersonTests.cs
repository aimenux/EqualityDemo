using FluentAssertions;
using Lib.Examples.IEqualityComparer.Generic;

namespace Tests.IEqualityComparer.Generic;

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

    [Fact]
    public void ShouldGetDistinctPersons()
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

        var person3 = new Person
        {
            FirstName = "Ned",
            LastName = "Stark"
        };

        var persons = new List<Person>
        {
            person1, person2, person3
        };

        var comparer = new PersonEqualityComparer();

        // act
        var distinct = persons.Distinct(comparer);

        // assert
        distinct.Should().BeEquivalentTo(new List<Person>
        {
            person1,
            person3
        });
    }
}