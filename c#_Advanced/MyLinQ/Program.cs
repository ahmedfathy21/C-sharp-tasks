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



        #endregion

    }

    dynamic print(dynamic name)
    {

return name;
    }
}