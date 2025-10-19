using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace MyLinQ;

public class Employee : IEquatable<Employee> , IEnumerable<Employee> , IEqualityComparer<Employee>
{
    public Employee()
    {
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public bool Equals(Employee? other)
    {
        if (other is null) return false;
        return this.Id == other.Id && this.Name == other.Name && this.Age == other.Age && this.Salary == other.Salary;
    }
    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != typeof(Employee)) return false;
        Employee emp = (Employee)obj;
        return this.Id == emp.Id && this.Name == emp.Name && this.Age == emp.Age && this.Salary == emp.Salary;
    }

    public bool Equals(Employee? x, Employee? y)
    {
        if (x is null || y is null) return false;
        return x.Id == y.Id && x.Name == y.Name && x.Age == y.Age && x.Salary == y.Salary;
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }

    public int GetHashCode([DisallowNull] Employee obj)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}