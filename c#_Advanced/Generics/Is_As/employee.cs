namespace Is_As;

public class Employee : IEquatable<Employee>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }

    public Employee()
    {
        Name = string.Empty;
        Department = string.Empty;
    }

    public Employee(string name, int age, string department)
    {
        Name = name;
        Age = age;
        Department = department;
    }

    public bool Equals(Employee? employee)
    {
        if (employee is not null)
        {
            return Name == employee.Name && Age == employee.Age && Department == employee.Department;
            
        }
        else
        {
            return false;
        }
    }

    public override bool Equals(object? obj)
    {
        return obj is Employee emp &&
               Name == emp.Name &&
               Age == emp.Age &&
               Department==emp.Department;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age, Department);
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Department: {Department}";
    }
}