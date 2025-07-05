namespace Bubble_sort;

public class student : IEquatable<student> , IComparable<student>

{
    public student(string name, int age, string major)
    {
        this.name = name;
        this.age = age; 
        this.major = major;
    }

    public string name { get; set; }
public int age { get; set; }
    
public string major { get; set; }

public int CompareTo(student? student)
{
    if (student is null)
        return 1;
    else
       return this.age.CompareTo(student.age);

}

public override bool Equals(object? obj)
{
    return obj is  student std &&
           name == std.name&&
           age == std.age&&
           major == std.major;
}

public override int GetHashCode()
{
    return HashCode.Combine(name, age, major);
}

public override string ToString()
{
    return $" The name = {this.name}, Age = {this.age}, Major = {this.major}";
}

public bool Equals(student? std)
{
    return name == std.name && age == std.age && major == std.major;
}
}