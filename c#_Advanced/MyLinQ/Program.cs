namespace MyLinQ;

class Program
{
    static void Main(string[] args)
    {
        #region C# KeyWords

        // The var keyword don`t has something special like int , string 
        // can`t be initialized as a null or not initialized must be initialized 
        // not most properly secured , Implicitly data type
        var name = "Ahmed";

        // dynamic don`t need have to be defined 
        dynamic name2 = "Ahmed"; 
        
        
        // anonymous Type 
         var person = new { name = "Ahmed", age = 20 };
         var person2 = new { Name = "Ahmed", age = 20 };
         Console.WriteLine(person.Equals(person2));
         Console.WriteLine(person.GetType());
         
         /* person.name = "Fatma";   no option to change the Value of the anonymous data type after the creation */

         
         

        #endregion

        #region LINQ!
        
        
        
        #endregion
    }

 
  
}