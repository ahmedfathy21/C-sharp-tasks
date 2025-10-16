using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
namespace Is_As;

internal class Employeenameequalitycomarer : IEqualityComparer<Employee>
{
    public bool Equals(Employee? x, Employee? y)
    {
            return x?.Name == y?.Name;
    }

    public int GetHashCode([DisallowNull]Employee obj)
    {
        return HashCode.Combine(obj.Name);
        
    }
}