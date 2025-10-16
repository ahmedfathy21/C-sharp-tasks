namespace Delegate;
public delegate bool SortingTypeDelegate<T>(T a, T b);
public static class SortingAlgorithms<T>
{
    public static void BubbleSort( T []array, SortingTypeDelegate<T> sortingtype)
    {
        if (array?.Length > 0 )
        {
        for (var i = 0; i < array.Length - 1; i++)
        {
            for (var j = 0; j < array.Length - 1 - i; j++)
            { 
if (sortingtype(array[j], array[j + 1]))
                    Swap(ref array[j], ref array[j + 1]);
            }
        }
        }
        
    }

    private static void Swap(ref T i, ref T i1)
    {
        (i, i1) = (i1, i);
    }
}