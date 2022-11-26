using System.Collections;
using FluentAssertions;
using Lib.Examples.IStructuralEquatable;

namespace Tests.IStructuralEquatable;

public class PersonsTests
{
    [Fact]
    public void ShouldEqualsReturnTrue_V1()
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

        var collection1 = new Persons { person1, person2 };
        var collection2 = new Persons { person1, person2 };
        var comparer = StructuralComparisons.StructuralEqualityComparer;

        // act
        var equals = comparer.Equals(collection1, collection2);
        var equalsAlso = collection1.Equals(collection2, comparer);

        // assert
        equals.Should().BeTrue();
        equalsAlso.Should().BeTrue();
    }

    [Fact]
    public void ShouldEqualsReturnTrue_V2()
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

        var collection1 = new Person[] { person1, person2 };
        var collection2 = new Person[] { person1, person2 };
        var comparer = StructuralComparisons.StructuralEqualityComparer;

        // act
        var equals = comparer.Equals(collection1, collection2);

        // assert
        equals.Should().BeTrue();
    }

    [Fact]
    public void ShouldEqualsReturnFalse_V1()
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

        var collection1 = new Persons { person1, person2 };
        var collection2 = new Persons { person1, person2 };
        var comparer = StructuralComparisons.StructuralEqualityComparer;

        // act
        var equals = comparer.Equals(collection1, collection2);

        // assert
        equals.Should().BeTrue();
    }

    [Fact]
    public void ShouldEqualsReturnFalse_V2()
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

        var collection1 = new Person[] { person1, person2 };
        var collection2 = new Person[] { person1, person2 };
        var comparer = StructuralComparisons.StructuralEqualityComparer;

        // act
        var equals = comparer.Equals(collection1, collection2);

        // assert
        equals.Should().BeTrue();
    }
}