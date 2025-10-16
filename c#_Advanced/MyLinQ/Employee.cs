namespace MyLinQ;

// public class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public int Salary { get; set; }
//     
//     public override bool Equals(object? obj)
//     {
//         if (obj == null || GetType() != obj.GetType())
//             return false;
//
//         Employee other = (Employee)obj;
//         return Id == other.Id;
//     }
//
//     public override int GetHashCode()
//     {
//         return Id.GetHashCode();
//     }
//
//     public override string ToString()
//     {
//         return $"Employee[Id={Id}, Name={Name}, Age={Age}, Salary={Salary}]";
//     }
// }