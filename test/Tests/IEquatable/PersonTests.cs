using FluentAssertions;
using Lib.Examples.IEquatable;

namespace Tests.IEquatable;

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

        // act
        var equals = person1.Equals(person2);
        var equalsAlso = person1 == person2;

        // assert
        equals.Should().BeTrue();
        equalsAlso.Should().BeTrue();
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

        // act
        var equals = person1.Equals(person2);
        var equalsAlso = person1 == person2;

        // assert
        equals.Should().BeFalse();
        equalsAlso.Should().BeFalse();
    }

    [Fact]
    public void ShouldCollectionBehaviourBeValid()
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

        var set = new HashSet<Person>
        {
            person1, person2
        };

        var list = new List<Person>
        {
            person1, person2
        };

        var dic = new Dictionary<Person, string>
        {
            [person1] = nameof(person1)
        };

        // act
        var setCount = set.Count;
        var listDistinctCount = list.Distinct().Count();
        var isAdded = dic.TryAdd(person2, nameof(person2));

        // assert
        setCount.Should().Be(1);
        listDistinctCount.Should().Be(1);
        isAdded.Should().BeFalse();
    }
}