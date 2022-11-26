namespace Lib.Examples.IStructuralComparable;

public class Persons : List<Person>, System.Collections.IStructuralComparable
{
    public int CompareTo(object other, System.Collections.IComparer comparer)
    {
        if (other is not Persons persons)
        {
            throw new ArgumentException($"Object must be of type {nameof(Persons)}");
        }

        return comparer.Compare(this.ToArray(), persons.ToArray());
    }
}