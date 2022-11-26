using FluentAssertions;
using Lib.Examples.IStructuralComparable;
using System.Collections;

namespace Tests.IStructuralComparable;

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

        var collection1 = new Persons { person1, person2 };
        var collection2 = new Persons { person1, person2 };
        var comparer = StructuralComparisons.StructuralComparer;

        // act
        var result = comparer.Compare(collection1, collection2);
        var resultAlso = collection1.CompareTo(collection2, comparer);

        // assert
        result.Should().Be(0);
        resultAlso.Should().Be(0);
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

        var collection1 = new Persons { person1, person1 };
        var collection2 = new Persons { person2, person2 };
        var comparer = StructuralComparisons.StructuralComparer;

        // act
        var result = comparer.Compare(collection1, collection2);
        var resultAlso = collection1.CompareTo(collection2, comparer);

        // assert
        result.Should().Be(1);
        resultAlso.Should().Be(1);
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

        var collection1 = new Persons { person1, person1 };
        var collection2 = new Persons { person2, person2 };
        var comparer = StructuralComparisons.StructuralComparer;

        // act
        var result = comparer.Compare(collection1, collection2);
        var resultAlso = collection1.CompareTo(collection2, comparer);

        // assert
        result.Should().Be(-1);
        resultAlso.Should().Be(-1);
    }
}