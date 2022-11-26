namespace Lib.Examples.Equals;

public class Person
{
    public string FirstName { get; init; }

    public string LastName { get; init; }

    public override bool Equals(object obj)
    {
        if (obj is not Person person) return false;

        return string.Equals(FirstName, person.FirstName)
               && string.Equals(LastName, person.LastName);
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