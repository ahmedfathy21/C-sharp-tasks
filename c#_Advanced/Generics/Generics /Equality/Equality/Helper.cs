namespace Generics;

internal static class Helper<T>
{

    public static int LinearSearch(T[] arr, T value)
    {
        if (arr?.Length <= 0 ) return -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(value))
                return i;
        }
        return -1;
    }
    public static void Swap(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
            }
    
}