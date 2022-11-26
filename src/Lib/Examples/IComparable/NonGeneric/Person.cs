namespace Lib.Examples.IComparable.NonGeneric;

public class Person : System.IComparable
{
    public string FirstName { get; init; }

    public string LastName { get; init; }

    public int CompareTo(object obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        if (obj is not Person person)
        {
            throw new ArgumentException($"Object must be of type {nameof(Person)}");
        }
        return CompareTo(person);
    }

    private int CompareTo(Person other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var firstNameComparison = string.Compare(FirstName, other.FirstName, StringComparison.Ordinal);
        if (firstNameComparison != 0) return firstNameComparison;
        return string.Compare(LastName, other.LastName, StringComparison.Ordinal);
    }
}