namespace Delegate;

public delegate int StringFuncDelegate(string str);

class Program
{ 
    static void Main(string[] args)
    {
       /* #region delegate operation

        StringFuncDelegate StringDelegate; // Declare the delegate and let it points to null 
        StringDelegate = StringFunctions.GetCountOfUppercaseLetters; // Initialize the delegate to point to the function 
        StringDelegate+= StringFunctions.GetCountOfLowercaseLetters; // Add another function to the delegate
        int result = StringDelegate?.Invoke("Hello World") ?? -1; // Invoke the delegate
        Console.WriteLine($"The count of uppercase letters is {result}");

        #endregion */ 

        /*#region Sorting Algorithms

        SortingTypeDelegate<int> sortingtype = SortingType.SortingTypeDelegateFun; // SortingTypeDelegateFunAce;
        int [] array = { 5,4,6,7,8,9,5,2,3,1,0};
        SortingAlgorithms<int>.BubbleSort(array , sortingtype);
        foreach (var item in array)
            Console.WriteLine($" {item}");
        sortingtype+= SortingType.SortingTypeDelegateFunDec;
        Console.WriteLine("Sorted in descending order");
        SortingAlgorithms<int>.BubbleSort(array , sortingtype);
        foreach (var item in array)
            Console.WriteLine($" {item}");
       
        #endregion*/

        #region SortString

        string [] array1 = {"Ahmed", "Fatma", "Salma", "Fathy", "zee"};
        SortingTypeDelegate<string> sorttype = SortingType.SortstringTypeDelegateFunAse;
        SortingAlgorithms<string>.BubbleSort(array1 , sorttype);
        foreach (var item in array1)
            Console.WriteLine($" {item}");
        Console.WriteLine("Sorted in descending order");
        sorttype = SortingType.SortstringTypeDelegateFunDesc;
        SortingAlgorithms<string>.BubbleSort(array1 , sorttype);
        foreach (var item in array1)
            Console.WriteLine($" {item}");
        #endregion
    }
}