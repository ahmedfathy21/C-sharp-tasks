namespace Delegate;
 
public static class SortingType
{
    public static bool SortingTypeDelegateFun(int a, int b)
    {
        return a > b;
    }
    public static bool SortingTypeDelegateFunDec(int a, int b)
    {
        return a < b;
    }
    public static bool SortstringTypeDelegateFunAse(string a, string b)
    {
        return a?.Length > b?.Length;
    }
    public static bool SortstringTypeDelegateFunDesc(string a, string b)
    {
        return a?.Length < b?.Length;
    }
}