using System.Collections;

namespace Delegate;

public delegate int StringFuncDelegate(string str);

class Program
{
    /// <summary>
    /// The entry point of the program.
    /// </summary>
    /// <param name="args">An array of command-line arguments.</param>
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

        // #region SortString
        //
        // string [] array1 = {"Ahmed", "Fatma", "Salma", "Fathy", "zee"};
        // SortingTypeDelegate<string> sorttype = SortingType.SortstringTypeDelegateFunAse;
        // SortingAlgorithms<string>.BubbleSort(array1 , sorttype);
        // foreach (var item in array1)
        //     Console.WriteLine($" {item}");
        // Console.WriteLine("Sorted in descending order");
        // sorttype = SortingType.SortstringTypeDelegateFunDesc;
        // SortingAlgorithms<string>.BubbleSort(array1 , sorttype);
        // foreach (var item in array1)
        //     Console.WriteLine($" {item}");
        // #endregion

        // #region NewMethodsWithLists
        //
        // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 ,6,7,8,9,10};
        //  List<int> index = numbers.FindAll(x => x % 2 == 0);
        //  foreach (var VARIABLE in index)
        //  {
        //      Console.WriteLine(VARIABLE);
        //  }
        //
        // #endregion

        // Action action = FunctionReturnDelgate.DelegateAction();
        // action.Invoke();
        // Console.WriteLine(FunctionReturnDelgate.DelegatePredicate()(10));
        // string name = FunctionReturnDelgate.DelegateFunc()(['H','E','L','L','O']);
        // Console.WriteLine(name);

        //    #region Hashtable
        //    Hashtable hashtable = new Hashtable
        //    {   
        //        ["Ahmed"] = 10,
        //        ["Ali"] = 11,
        //        ["Sandy"] = 12,
        //    };
        //    foreach (DictionaryEntry direcroty in hashtable)
        //    {
        //        Console.WriteLine($"{direcroty.Key} = {direcroty.Value}");
        //        
        //    }
        // #endregion

        // #region Dictionary Generic
        //    Dictionary<string,int>dic = new Dictionary<string, int>() 
        //    {
        //        ["Ahmed"] = 10,
        //        ["Ali"] = 11,
        //        ["Sandy"] = 12,
        //    };
        //    foreach (var item in dic.Keys)
        //        Console.WriteLine($"{item} = {dic[item]}");
        // #endregion

        // #region Indexer Generic
        //
        // // Using the indexer as a getter  
        // if(dic.ContainsKey("Ahmed")) // returns true 
        // Console.WriteLine($" The value of the key Ahmed is {dic["Ahmed"]}"); // not safely might be throwing an exception 
        // // Using the indexer as a setter  
        // dic["Ahmed"] = 100;
        // dic["Alil"] = 101;
        //
        // foreach (var item in dic.Keys)
        //     Console.WriteLine($"{item} = {dic[item]}");
        // #endregion

        //  #region Dictionary Classes
        //
        //  Employee employee01 = new Employee(1,"Ahmed", 12, 10000);
        //  Employee employee02 = new Employee(2,"Fatma", 13, 10000); 
        //  Employee employee03 = new Employee(3,"Ali", 14, 10000);
        //     
        //  
        //  Dictionary<Employee, string> employes = new Dictionary<Employee, string>(new EmployeeEqualityIdComparere())
        //  {
        //      [employee01] = "1st",
        //      [employee02]  = "2nd",
        //      [employee03] = "3rd"
        //  };
        //  foreach (KeyValuePair<Employee,string> employe in employes)
        //  {
        //      Console.WriteLine($" {employe.Key.Id}{employe.Key.Name} , {employe.Key.Age} , {employe.Key.Salary}  {employe.Value}");
        //  }
        //  Employee employee04 = new Employee(4,"Ali", 14, 10000);
        //  employes.Add(employee04,"4th");
        //  
        //  foreach (var employe in employes)
        //  {
        //      Console.WriteLine($" {employe.Key.Id}{employe.Key.Name} , {employe.Key.Age} , {employe.Key.Salary}  {employe.Value}");
        //  }
        //
        //  Employee employee05 = new Employee(5,"Fatma", 13, 10000);
        //  employes.Add(employee05 , "5th");
        //  foreach (var employe in employes)
        //  {
        //      Console.WriteLine($" {employe.Key.Id}{employe.Key.Name} , {employe.Key.Age} , {employe.Key.Salary}  {employe.Value}");
        //  }
        //  #endregion
        // }

        // #region Sorted Dictionary
        //
        // SortedDictionary<string, int> sorteddic = new SortedDictionary<string, int>(new SortedString()) 
        // {
        //     ["Sandy"] = 12,
        //     ["Fatma"] = 13,
        //     ["Zee"] = 14,
        //     ["Nancy"] = 15,
        //     ["Salma"] = 16,
        //     ["Ali"] = 17,
        //     ["Ahmed"] = 10,
        //     ["Ali"] = 11,
        //    
        // };
        // foreach (var i in sorteddic)
        // {
        //     Console.WriteLine(i);
        // }
        //
        //
        // #endregion
        //
        // #region HashSet
        //
        // HashSet<string> names = new HashSet<string>()
        // {
        //     "Ahmed",
        //     "Fatma",
        //     "Zee",
        //     "Ahmed",
        // };
        //
        // foreach (string name in names)
        // {
        //     Console.WriteLine(name);
        // }
        //
        // HashSet<Employee> employees = new HashSet<Employee>()
        // {
        //     new Employee(1, "Ahmed", 12, 10000),
        //     new Employee(2, "Ahmed", 12, 10000),
        //     new Employee(3, "Ali", 14, 10000),
        //     new Employee(4, "Ali", 14, 10000),
        // };
        // foreach (var employee in employees)
        //     Console.WriteLine(employee);
        //
        //
        // #endregion
        #region SortedSet

        SortedSet<int> numbers = new SortedSet<int>()
        {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9, };
        List <int> ListedNumbers = numbers.Reverse().ToList();
        foreach (var Item in ListedNumbers)
        {
            Console.WriteLine(Item);
            
        }
        #endregion
    }
}