using System.Runtime.ExceptionServices;
using Bubble_sort;

namespace Is_As;

public class Helper<T> where T : IEquatable<T>  , IComparable<T>

{
        public static int Linear_Search(T[] arr, T value ,EqualityComparer<T> employeeComparer)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // if (arr[i].Equals(value))
                if (employeeComparer.Equals(arr[i], value))
                {
                    return i;
    
                }
            }
            return -1;
        }

    public static void Bouble_sort(T[]? array)
    {

        if (array is not null)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                        Swap(ref array[j], ref  array[j+1]);
                }
            }
            
        }
      
        
    }
    public static void bubble_sort(T[]? array ,IComparer<T> comparer)
    {
        if (array is not null)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - 1 - i; j++)
                    
                    if(comparer.Compare(array[j], array[j+1]) > 0)  // ascending sort form low to high sort 
                        Swap(ref array[j], ref array[j+1]);
            }
        }
        
    }

    public static void Swap(ref T a, ref T b)
    {
        T temp  = a;
        a = b;
        b = temp;
    }
 
}