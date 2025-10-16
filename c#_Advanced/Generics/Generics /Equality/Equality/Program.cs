using System.Runtime.InteropServices;
namespace Generics

{
    // Example of using 'is' and 'as' operators in C#
    // This code demonstrates type checking and safe casting
    internal class Program
    {
        public static void Main()
        {
                Employee emp01 = new Employee("John", 25, "Computer Science");
                Employee emp02 = new Employee("John", 25, "Computer Science");

                Console.WriteLine(emp01.Equals(emp02));
                Console.WriteLine(emp01.GetHashCode());
                Console.WriteLine(emp02.GetHashCode());
                
            
            // string name01 = "john";
            // string name02 = "John";
            // if (name01 == name02) // string is a class , its compares between reference   
            // {
            //     Console.WriteLine("They are the same");
            // }
            // else
            // {
            //     Console.WriteLine("They are not the same!! ");
            // }
            // Console.WriteLine(name01.Equals(name02));
            // Console.WriteLine(name01.GetHashCode());
            // Console.WriteLine(name02.GetHashCode());

            // int a = 10, b = 20;
            // Console.WriteLine($"A = {a}, B = {b}");
            // Helper<int>.Swap(ref a, ref b);
            // Console.WriteLine("After swapping ");
            // Console.WriteLine(a == b);
            // Console.WriteLine($"A = {a}, B = {b}");
            //
            // point point01 = new point(10, 20);
            // point point02 = new point(50, 60);
            // Console.WriteLine($"point 01 = {point01.x} , {point01.y}");
            // Console.WriteLine($"point 02 = {point02.x} , {point02.y}");
            //
            // Helper.Swap(ref point01, ref point02);
            // Console.WriteLine("After swapping the points ");
            // Console.WriteLine($"point 01 = {point01.x} , {point01.y}");
            // Console.WriteLine($"point 02 = {point02.x} , {point02.y}");
           
              // int [] numbers = {9,5,8,7,6,4,3,2,1 };
              //            Console.WriteLine($"The index of the number 3 is { Helper<int>.LinearSearch(numbers, 3)}");

              // employee[] empolyees =
              // {
              //     new employee("John", 25, "Computer Science"),
              //     new employee("Jane", 23, "Computer Science"),
              //     new employee("Jane", 23, "Computer Science"),
              //     new employee("Jessica", 22, "Computer Science"),
              // };
              // employee emploee02 = new employee("Jessica", 22, "Computer Science");
              // employee emploee01 = new employee("Jessica", 22, "Computer Science");
              // Console.WriteLine(emploee01.Equals(emploee02));
              // int index = Helper<employee>.LinearSearch(empolyees, emploee01);
              // Console.WriteLine($"The index of the employee is {index} , {empolyees[index]}");
              // Console.WriteLine(empolyees[1]);

        }
    }


    class Employee 
    {
        public string name { get; set; }
        public int age { get; set; }

        public string major { get; set; }

        public Employee(string name, int age , string major)
        
        {
            this.major = major;
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age} , Major: {major}";
        }

        public override bool Equals(object obj)
        {
            return obj is Employee emp &&
                   name == emp.name &&
                   age == emp.age &&
                   major == emp.major;
        }

  

        public override int GetHashCode()
        {
            return HashCode.Combine(name, age, major); // utility method helps me to generate hash code 
        }
    }
}
