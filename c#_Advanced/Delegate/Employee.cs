namespace Delegate;

public class Employee
{
    public int Id { get;  }
    public string Name { get; }
    public int Age { get; }
    public int Salary { get; }


    public Employee(int id ,string name, int age, int salary)
    {
        Id = id;
        Name = name;
        Age = age;
        Salary = salary;
    }

    public override bool Equals(object? obj)
    {
        Employee? employee = obj as Employee;
        if (employee is null)
            return false;
        else
           return employee.Name == Name && employee.Age == Age && employee.Salary == Salary;
        
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age, Salary);
    }
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
    }
}

