namespace Lib.Examples.IComparable.Generic;

public class Person : IComparable<Person>
{
    public string FirstName { get; init; }

    public string LastName { get; init; }

    public int CompareTo(Person other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var firstNameComparison = string.Compare(FirstName, other.FirstName, StringComparison.Ordinal);
        if (firstNameComparison != 0) return firstNameComparison;
        return string.Compare(LastName, other.LastName, StringComparison.Ordinal);
    }
}