namespace Lib.Examples.IEquatable;

public class Person : IEquatable<Person>
{
    public string FirstName { get; init; }

    public string LastName { get; init; }

    public override bool Equals(object obj)
    {
        return obj is Person person && Equals(person);
    }

    public bool Equals(Person other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return FirstName == other.FirstName && LastName == other.LastName;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName);
    }

    public static bool operator ==(Person left, Person right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Person left, Person right)
    {
        return !Equals(left, right);
    }
}