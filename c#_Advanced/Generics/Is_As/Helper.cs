namespace Is_As;

public class Helper<T> where T : IEquatable<T>

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
 public static void Swap(ref T a, ref T b)
 {
  (a, b) = (b, a);
 }
 
}