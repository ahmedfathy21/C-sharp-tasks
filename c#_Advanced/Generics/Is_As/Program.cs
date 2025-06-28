using System;
using System.Collections.Generic;

namespace Is_As
{
    public class Program
    {
        /// <summary>                Console.WriteLine(emp01.GetHashCode());

        /// Entry point of the application demonstrating the usage of "is" and "as" operators,
        /// along with performing operations such as object type checks, casting, and swapping generic objects.
        /// </summary>
        public static void Main()
        {
            // Is operator using for comparing and explicit casting either
          //  #region IS operator
            // Employee employee01 = new Employee("Ahmed", 25, "Computer Science");
            // Employee employee02 = new Employee("Fatma", 23, "maths");
            // Console.WriteLine(employee01 is Employee);
            // string name = "Ahmed";
            // if (name is Employee)
            // {
            //     Console.WriteLine($"{name} is an employee");
            // }
            // else
            // {
            //     Console.WriteLine($"{name} is not an employee");    
            // }
            //





            // #endregion
            // AS operator using as a soft cast, there are no exceptions expected or whatever 
            // #region AS operator

            // Employee employee03 = new Employee("Ali", 25, "Computer Science");
            // Employee employee04 = new Employee("Zee", 23, "Medicine");
            // object? obj = employee04 as object;
            // Console.WriteLine(obj.GetType());
            // Console.WriteLine($"Before Swap {employee01} {employee02 }");
            // Helper<Employee>.Swap(ref employee01, ref employee02);
            // Console.WriteLine("===========================");
            // Console.WriteLine($"After Swap {employee01} {employee02 }");
            //
            //
            //
            //
            //
            // #endregion
            Employee[] employees =
            {
                new Employee("Ahmed", 25, "Computer Science"),
                new Employee("Fatma", 23, "maths"),
                new Employee("sayed", 25, "Computer Science"),
                new Employee("Zee", 23, "Medicine"),
                new Employee("fayez", 23, "maths"),
                new Employee("Nancy", 25, "Computer Science"),
                new Employee("Salma", 23, "maths"),
                new Employee("Ali", 25, "Computer Science"),
                new Employee("Zeen", 40, "Medicine"),
            };
            Employee employee = new Employee("Zee", 40, "Medicine");
int index = Helper<Employee>.Linear_Search(employees, employee,EqualityComparer<Employee>.Create(new Employeenameequalitycomarer().Equals));
            Console.WriteLine(index);
        }
    }
}