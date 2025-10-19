using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace MyLinQ;
class Program
{
   
    static void Main(string[] args)
    {
        
        #region C# KeyWords

        

        List<Department> DepartmenList = Data.GetDepartments();
        List<Employee> EmplyeeList = Data.GetEmployess();
        
        var FilteredEmployee = EmplyeeList.Where(employee => employee.FirstName == "Ahmed").ToList();
        foreach ( var item in FilteredEmployee)
            Console.WriteLine(item);
        var MaxSalary = EmplyeeList.Max(employee => employee.Salary);
        var AverageSalary = EmplyeeList.Average(employee => employee.Salary);
        var SumSalary = EmplyeeList.Sum(employee => employee.Salary);
        Console.WriteLine(MaxSalary);
        var FilteredDepartments = DepartmenList.Where(department => department.LongName == "Human Resource");
        foreach (var item in FilteredDepartments)
            Console.WriteLine(item);
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