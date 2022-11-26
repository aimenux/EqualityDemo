namespace Lib.Examples.IComparer.Generic;

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (ReferenceEquals(null, y)) return 1;
        if (ReferenceEquals(null, x)) return -1;
        var firstNameComparison = string.Compare(x.FirstName, y.FirstName, StringComparison.Ordinal);
        if (firstNameComparison != 0) return firstNameComparison;
        return string.Compare(x.LastName, y.LastName, StringComparison.Ordinal);
    }
}