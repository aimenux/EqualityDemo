namespace Lib.Examples.IEqualityComparer.NotGeneric;

public class Person : System.Collections.IEqualityComparer
{
    public string FirstName { get; init; }

    public string LastName { get; init; }

    public new bool Equals(object x, object y)
    {
        if (x is Person p1 && y is Person p2)
        {
            return string.Equals(p1.FirstName, p2.FirstName)
                   && string.Equals(p1.LastName, p2.LastName);
        }

        if (x is null || y is null)
        {
            return x == y;
        }

        return x.Equals(y);
    }

    public int GetHashCode(object obj)
    {
        return obj switch
        {
            null => 0,
            Person person => HashCode.Combine(person.FirstName, person.LastName),
            _ => obj.GetHashCode()
        };
    }
}