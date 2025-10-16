using System.Diagnostics.CodeAnalysis;

namespace Is_As;

public struct employee_struct : IEquatable<employee_struct>
{
    public employee_struct(string name, int age, string department)
    {
        this.name = name;
        this.age = age;
        this.department = department;
    }

    public string name { get; set; }
    public int age { get; set; }
    public string department{ get; set; }

        // struct cannot be applicable  with noneable parameters when using the IEquatable  
    public bool Equals(employee_struct employee)
    {
        
            return name == employee.name && age == employee.age && department == employee.department;
    }

    public override bool Equals(object? obj)
    {
        return obj is employee_struct emp &&
               name == emp.name &&
               age == emp.age &&
               department==emp.department;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(name, age, department);
    }

    public override string ToString()
    {
        return $"Name = {name}, Age = {age}, department = {department}";
    }
}