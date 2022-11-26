namespace Lib.Examples.IComparer.NonGeneric;

public class PersonComparer : System.Collections.IComparer
{
    public int Compare(object x, object y)
    {
        if (x is not Person p1 || y is not Person p2)
        {
            throw new ArgumentException($"Object must be of type {nameof(Person)}");
        }

        return Compare(p1, p2);
    }

    private static int Compare(Person x, Person y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (ReferenceEquals(null, y)) return 1;
        if (ReferenceEquals(null, x)) return -1;
        var firstNameComparison = string.Compare(x.FirstName, y.FirstName, StringComparison.Ordinal);
        if (firstNameComparison != 0) return firstNameComparison;
        return string.Compare(x.LastName, y.LastName, StringComparison.Ordinal);
    }
}