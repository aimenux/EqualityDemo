namespace Lib.Examples.IStructuralEquatable;

public class Persons : List<Person>, System.Collections.IStructuralEquatable
{
    public bool Equals(object other, System.Collections.IEqualityComparer comparer)
    {
        if (other is not Persons persons)
        {
            throw new ArgumentException($"Object must be of type {nameof(Persons)}");
        }

        return comparer.Equals(this.ToArray(), persons.ToArray());
    }

    public int GetHashCode(System.Collections.IEqualityComparer comparer)
    {
        return comparer.GetHashCode(this);
    }
}