namespace Delegate;

public class SortedString : IComparer<string>
{
    public int Compare(string? x, string? y) => y?.CompareTo(x) ?? -1;
    
}