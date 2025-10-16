namespace Delegate;

internal class FunctionReturnDelgate
{
    public static Action DelegateAction()
    {
        return () =>Console.WriteLine("Hello World"); // Delegate anonymous Function 
    }

    public static Predicate<int> DelegatePredicate()
    {
        // return delegate(int i) { return i > 10; }; // Delegate Predicate
        return i => i > 10;
    }

    public static Func<char[], string> DelegateFunc()
    {
        return delegate (char[] arr) { return new string(arr); }; // Delegate Func
    }
}