namespace MyLinQ;

class Program
{
    static void Main(string[] args)
    {
        // #region C# KeyWords

        // // // The var keyword don`t has something special like int , string 
        // // // can`t be initialized as a null or not initialized must be initialized 
        // // // not most properly secured , Implicitly data type
        // // var name = "Ahmed";
        //
        // // // dynamic don`t need have to be defined 
        // // dynamic name2 = "Ahmed";
        //
        //
        // // // anonymous Type 
        // // var person = new { name = "Ahmed", age = 20 };
        // // var person2 = new { Name = "Ahmed", age = 20 };
        // // Console.WriteLine(person.Equals(person2));
        // // Console.WriteLine(person.GetType());
        //
        // /* person.name = "Fatma";   no option to change the Value of the anonymous data type after th  e creation */






        // #endregion

        #region LINQ!

        #region Fluent Syntax

        /* Fluent syntax Methods as a class member from Enumerable */
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var result = numbers.Where(number => number % 2 == 0);
        foreach (var item in result)
            Console.WriteLine(item);


        #endregion

        #region Query Syntax
        /* Easier when using Join Or GroupBy */
        var result01 = from N in numbers where N % 2 != 0 select N;
        foreach (var item in result01)
            Console.WriteLine(item);


        #endregion
        #region Linq Execution
        /* Deferred Execution */
        /* The query is not executed until you iterate over it */
        var query = from N in numbers where N % 2 == 0 select N;
        numbers.Add(12); // Adding a new number to the list
        foreach (var item in query)
            Console.WriteLine(item);

        /* Immediate Execution */
        /* The query is executed immediately and the result is stored in a list */
        // Using .ToList() here causes immediate execution, meaning the query is evaluated and results are stored in a list at this point.
        var evenNumbersImmediate = (from N in numbers where N % 2 == 0 select N).ToList();
        numbers.Add(14); // Adding a new number to the list
        foreach (var item in evenNumbersImmediate)
            Console.WriteLine(item); // The new number will not be included in the result
            

        #endregion

        #endregion
    }

 
  
}