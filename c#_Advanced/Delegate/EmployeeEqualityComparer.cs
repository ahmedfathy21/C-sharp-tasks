namespace Delegate;

public class EmployeeEqualityIdComparere : IEqualityComparer<Employee>
{
    public bool Equals(Employee? x, Employee? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (x is null) return false;
        if (y is null) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.Id == y.Id;
    }

    public int GetHashCode(Employee obj)
    {
        return HashCode.Combine(obj.Id);
    }
}