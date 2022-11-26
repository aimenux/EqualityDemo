namespace Lib.Examples.IStructuralEquatable;

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
}