using System.Collections;


namespace MyLinQ;

/// <summary>
/// Represents an employee with properties such as ID, Name, Age, and Salary.
/// </summary>
/// <remarks>
/// This class implements the IEquatable<Employee>, IEnumerable<Employee>, and IEqualityComparer<Employee> interfaces
/// to provide equality comparison and enumeration features for Employee objects.
/// </remarks>
public class Employee : IEnumerable<Employee>
{
   
    public Employee(int id, string firstName, string lastName, int age, decimal salary, bool isManger, int departmentId)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
        IsManger = isManger;
        DepartmentId = departmentId;
    }

    public Employee()
    {
        
    }


    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public bool IsManger { get; set; }
    
    public int DepartmentId { get; set; }
    
    public bool Equals(Employee? other)
    {
        if (other is null) return false;
        return this.Id == other.Id && this.FirstName == other.FirstName && this.Age == other.Age && this.Salary == other.Salary && this.LastName == other.LastName;
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != typeof(Employee)) return false;
        Employee emp = (Employee)obj;
        return this.Id == emp.Id && this.FirstName == emp.FirstName && this.Age == emp.Age && this.Salary == emp.Salary && this.LastName == emp.LastName;
    }

    public override string ToString()
    {
        return "$ FirstName: " + FirstName + " LastName: " + LastName + " Age: " + Age + " Salary: " + Salary + " IsManger: " + IsManger + " DepartmentId: " + DepartmentId + "";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Equals(Employee? x, Employee? y)
    {
        if (x is null || y is null) return false;
        return x.Id == y.Id && x.FirstName == y.FirstName && x.Age == y.Age && x.Salary == y.Salary && x.LastName == y.LastName;
    }
    
}