using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinQ;
class Program
{

    static void Main(string[] args)
    {

        #region C# KeyWords

        // string [] groups = { "Fruits", "Vegetables", "Meat", "Dairy" };
        // IEnumerable<IGrouping<char , string >> queryFoodGroups = from item in groups group item by item[0];
        //
        // // Option 1: Show group key and all items in each group
        // foreach (var group in queryFoodGroups)
        // {
        //     Console.WriteLine($"Group : {group.Key}"); 
        //     foreach(var item in group)
        //         Console.WriteLine($"    {item}");
        //     Console.WriteLine();
        // }

        #region Join_syntax

        Employee employee = new Employee
            { FirstName = "Ahmed", LastName = "Fatma", Salary = 20000m, Age = 25, Id = 1, DepartmentId = 1 };
        Employee employee1 = new Employee
            { FirstName = "Samy", LastName = "Morad", Salary = 10000.15m, Age = 23, Id = 2, DepartmentId = 2 };
        Employee employee2 = new Employee
            { FirstName = "Sayed", LastName = "Fayez", Salary = 5436.50m, Age = 20, Id = 3, DepartmentId = 5 };
        Employee employee3 = new Employee
            { FirstName = "Ahmed", LastName = "Fatma", Salary = 20000m, Age = 25, Id = 1, DepartmentId = 1 };

        Employee[] employees = new Employee[] { employee, employee1, employee2, employee3 };
        Department department = new Department { LongName = "Human Resource", ShortName = "HR", DepartmentId = 1 };
        Department department1 = new Department { LongName = "Front-end", ShortName = "FR", DepartmentId = 2 };
        Department department2 = new Department { LongName = "Back-end", ShortName = "BK", DepartmentId = 3 };
        Department[] departments = new Department[] { department, department1, department2 };

        var fiteredresult =
            (from emp in employees
                join Dep in departments on emp.DepartmentId equals Dep.DepartmentId
                select new { emp.FirstName, emp.LastName, emp.Salary, emp.Age, emp.Id, Dep.LongName })
            .DistinctBy(x => x.FirstName).ToList();
        foreach (var item in fiteredresult)
            Console.WriteLine(item);

        var filteredquery = (from emp in employees
            group emp by emp.FirstName
            into g
            select new { FirstName = g.Key, Employees = g }).ToList();
        foreach (var item in filteredquery)
        {
            Console.WriteLine($" The first name is :{item.FirstName} ");
            foreach (var item1 in item.Employees)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine();
        }
            

    #endregion

        // List<Department> DepartmenList = Data.GetDepartments();
        // List<Employee> EmplyeeList = Data.GetEmployess();
        //  var result = EmplyeeList.Select( e => new { e.FirstName, e.LastName, e.Salary , e.Age , e.Id }).OrderBy(item => item.Salary).ToList().First();
        //  var FirstElementAfterFilter = EmplyeeList.Select(e => new Employee
        //      { FirstName = e.FirstName, LastName = e.LastName, Salary = e.Salary, Age = e.Age, Id = e.Id }).ToArray();
        //  Console.WriteLine(FirstElementAfterFilter[0]);
        // while (FirstElementAfterFilter.MoveNext())
        //  Console.WriteLine(FirstElementAfterFilter.Current);
         // foreach ( var item in result)
             // Console.WriteLine(var);
         // var result1 = from e in EmplyeeList
         //     select new
         //     {
         //         FirstName = e.FirstName = " " ,
         //         LastName = e.LastName + "",
         //         Salary = e.Salary,
         //         Age = e.Age,
         //         Id = e.Id,
         //     }; 
         // var resultegroup = from emp in result1 
         //                 group emp by emp.FirstName[0];
         // foreach (var item in resultegroup)
         // {
         //     Console.WriteLine(item.Key);
         //     foreach (var item1 in item)
         //     {
         //         Console.WriteLine($"    {item1.FirstName} {item1.LastName} {item1.Salary} {item1.Age} {item1.Id}" );
         //     }
         //     Console.WriteLine();
         // }
         Console.ReadKey();
        
        // var FilteredEmployee = EmplyeeList.Where(employee => employee.FirstName == "Ahmed").ToList();
        // foreach ( var item in FilteredEmployee)
        //     Console.WriteLine(item);
        // var MaxSalary = EmplyeeList.Max(employee => employee.Salary);
        // var AverageSalary = EmplyeeList.Average(employee => employee.Salary);
        // var SumSalary = EmplyeeList.Sum(employee => employee.Salary);
        // Console.WriteLine(MaxSalary);
        // var FilteredDepartments = DepartmenList.Where(department => department.LongName == "Human Resource");
        // foreach (var item in FilteredDepartments)
        //     Console.WriteLine(item);
        // The var keyword don`t has something special like int , string
        // can`t be initialized as a null or not initialized must be initialized 
        // not most properly secured , Implicitly data type
        var name = "Ahmed";
        
        // dynamic don`t need have to be defined 
        // dynamic name2 = "Ahmed";
        // System.Console.WriteLine($"Name : {name2}");
        
        // anonymous Type 
        // var person = new { name = "Ahmed", age = 20 };
        // var person2 = new { Name = "Ahmed", age = 20 };
        // Console.WriteLine(person.Equals(person2));
        // Console.WriteLine(person.GetType());
        
        /* person.name = "Fatma";   no option to change the Value of the anonymous data type after th  e creation */






        #endregion
    

        // #region LINQ!
        // Employee employee = new Employee();
        //
        // #region Fluent Syntax

        /* Fluent syntax Methods as a class member from Enumerable */
        // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // List<int> result = numbers.Where(number => number % 2 == 0).ToList();
        
        // Using the Extensions class methods
        // Console.WriteLine("Even numbers using Print extension:");
        
        // Or with custom format
        // Console.WriteLine("\nEven numbers with custom format:");
        
        // result.ForEach(item => Console.WriteLine(item));
        // Call the LINQ method thorugh the Enumerable class
        // var result1 = Enumerable.Where(numbers, numbers => numbers % 2 == 0);
        // System.Console.WriteLine("Fluent Syntax Result:");
        // foreach (var item in result)
        //     Console.WriteLine(item);

        // System.Console.WriteLine("Fluent Syntax Result1:");
        // foreach (var item in result1)
        //     Console.WriteLine(item);
        // #endregion

        #region Query Syntax
        /* Easier when using Join Or GroupBy */
        // var result01 = from N in numbers where N % 2 != 0 select N;
        // foreach (var item in result01)
        //     Console.WriteLine(item);


        #endregion
        #region Linq Execution
        /* Deferred Execution */
        /* The query is not executed until you iterate over it */
        // var query = from N in numbers where N % 2 == 0 select N;
        // numbers.Add(12); // Adding a new number to the list
        // foreach (var item in query)
        //     Console.WriteLine(item);

        /* Immediate Execution */
        /* The query is executed immediately and the result is stored in a list */
        // Using .ToList() here causes immediate execution, meaning the query is evaluated and results are stored in a list at this point.
        // var evenNumbersImmediate = (from N in numbers where N % 2 == 0 select N).ToList();
        // numbers.Add(14); // Adding a new number to the list
        // foreach (var item in evenNumbersImmediate)
        //     Console.WriteLine(item); // The new number will not be included in the result
            

        #endregion

        // #endregion
    }

 
  
}